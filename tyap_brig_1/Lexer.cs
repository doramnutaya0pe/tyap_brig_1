using System;
using System.Collections.Generic;
using System.Text;

namespace tyap_brig_1
{

    // ТИПЫ ЛЕКСЕМ
    public enum TokenType
    {
        EOF = 0,
        VAR = 1, BEGIN = 2, END = 3, INTEGER = 4,
        READ = 5, WRITE = 6, FOR = 7, TO = 8, DO = 9, END_FOR = 10,
        IDENTIFIER = 11,
        CONSTANT = 12,
        PLUS = 13, MINUS = 14, MULTIPLY = 15, ASSIGN = 16,
        COLON = 17, SEMICOLON = 18, COMMA = 19,
        LEFT_PAREN = 20, RIGHT_PAREN = 21,
        UNKNOWN = 99
    }

    // ЛЕКСЕМА
    public class Token
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
        public int Code { get { return (int)Type; } }

        public Token(TokenType type, string value, int line, int column)
        {
            Type = type;
            Value = value;
            Line = line;
            Column = column;
        }
    }

    // СИМВОЛ (переменная)
    public class Symbol
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public string Address { get; set; }
        public int Line { get; set; }

        public Symbol(int index, string name, string type, int line)
        {
            Index = index;
            Name = name;
            Type = type;
            Value = 0;
            Address = $"0x{index:X2}";
            Line = line;
        }
    }

    // ТАБЛИЦА СИМВОЛОВ
    public class SymbolTable
    {
        public List<Symbol> Symbols { get; private set; }

        public SymbolTable()
        {
            Symbols = new List<Symbol>();
        }

        public bool Contains(string name)
        {
            foreach (var s in Symbols)
                if (s.Name == name) return true;
            return false;
        }

        public Symbol Find(string name)
        {
            foreach (var s in Symbols)
                if (s.Name == name) return s;
            return null;
        }

        public Symbol Add(string name, string type, int line)
        {
            if (Contains(name)) return Find(name);
            Symbol sym = new Symbol(Symbols.Count + 1, name, type, line);
            Symbols.Add(sym);
            return sym;
        }

        public void Clear()
        {
            Symbols.Clear();
        }
    }

    // ЛЕКСИЧЕСКИЙ АНАЛИЗАТОР
    public class Lexer
    {
        private string source;
        private int position;
        private int line;
        private int column;

        private const int MAX_IDENTIFIER_LENGTH = 12;

        private static readonly Dictionary<string, TokenType> Keywords =
            new Dictionary<string, TokenType>()
        {
            { "VAR",     TokenType.VAR },
            { "BEGIN",   TokenType.BEGIN },
            { "END",     TokenType.END },
            { "INTEGER", TokenType.INTEGER },
            { "READ",    TokenType.READ },
            { "WRITE",   TokenType.WRITE },
            { "FOR",     TokenType.FOR },
            { "TO",      TokenType.TO },
            { "DO",      TokenType.DO },
            { "END_FOR", TokenType.END_FOR }
        };

        public List<Token> Tokens { get; private set; }
        public SymbolTable SymbolTable { get; private set; }
        public List<LexError> Errors { get; private set; }

        public Lexer(string sourceCode)
        {
            source = sourceCode ?? "";
            position = 0;
            line = 1;
            column = 1;
            Tokens = new List<Token>();
            SymbolTable = new SymbolTable();
            Errors = new List<LexError>();
        }

        /// <summary>
        /// Русское название типа лексемы (для вывода в таблицу)
        /// </summary>
        public static string GetRussianName(TokenType type)
        {
            switch (type)
            {
                case TokenType.VAR:
                case TokenType.BEGIN:
                case TokenType.END:
                case TokenType.INTEGER:
                case TokenType.READ:
                case TokenType.WRITE:
                case TokenType.FOR:
                case TokenType.TO:
                case TokenType.DO:
                case TokenType.END_FOR:
                    return "Ключевое слово";

                case TokenType.IDENTIFIER: return "Идентификатор";
                case TokenType.CONSTANT: return "Константа";

                case TokenType.PLUS:
                case TokenType.MINUS:
                case TokenType.MULTIPLY:
                case TokenType.ASSIGN:
                    return "Операция";

                case TokenType.COLON:
                case TokenType.SEMICOLON:
                case TokenType.COMMA:
                    return "Разделитель";

                case TokenType.LEFT_PAREN:
                case TokenType.RIGHT_PAREN:
                    return "Скобка";

                case TokenType.EOF: return "Конец файла";
                default: return "Неизвестно";
            }
        }

        public void Analyze()
        {
            while (!IsEnd())
            {
                char c = CurrentChar();

                if (char.IsWhiteSpace(c)) { NextChar(); continue; }
                if (char.IsLetter(c)) { ReadIdentifierOrKeyword(); continue; }
                if (char.IsDigit(c)) { ReadConstant(); continue; }
                if (ReadOperatorOrSeparator()) continue;

                AddError($"Недопустимый символ '{c}'");
                NextChar();
            }

            Tokens.Add(new Token(TokenType.EOF, "", line, column));
        }

        private void ReadIdentifierOrKeyword()
        {
            int startLine = line;
            int startColumn = column;
            StringBuilder sb = new StringBuilder();

            // Читаем буквы, цифры и подчёркивания
            // (подчёркивание нужно для END_FOR)
            while (!IsEnd() && (char.IsLetterOrDigit(CurrentChar()) || CurrentChar() == '_'))
            {
                sb.Append(CurrentChar());
                NextChar();
            }

            string word = sb.ToString();

            // 1. Ключевое слово?
            if (Keywords.ContainsKey(word))
            {
                Tokens.Add(new Token(Keywords[word], word, startLine, startColumn));
                return;
            }

            // 2. Идентификатор может содержать только буквы
            bool hasNonLetter = false;
            foreach (char ch in word)
            {
                if (!char.IsLetter(ch))
                {
                    hasNonLetter = true;
                    break;
                }
            }

            if (hasNonLetter)
            {
                AddError($"Идентификатор '{word}' может содержать только буквы",
                         startLine, startColumn);
            }

            // 3. Проверка длины
            if (word.Length > MAX_IDENTIFIER_LENGTH)
            {
                AddError($"Идентификатор '{word}' превышает максимальную длину ({MAX_IDENTIFIER_LENGTH})",
                         startLine, startColumn);
            }

            // 4. Добавляем в таблицу символов
            SymbolTable.Add(word, "INTEGER", startLine);
            Tokens.Add(new Token(TokenType.IDENTIFIER, word, startLine, startColumn));
        }

        private void ReadConstant()
        {
            int startLine = line;
            int startColumn = column;
            StringBuilder sb = new StringBuilder();

            while (!IsEnd() && char.IsDigit(CurrentChar()))
            {
                sb.Append(CurrentChar());
                NextChar();
            }

            Tokens.Add(new Token(TokenType.CONSTANT, sb.ToString(), startLine, startColumn));
        }

        private bool ReadOperatorOrSeparator()
        {
            char c = CurrentChar();
            int L = line, C = column;

            switch (c)
            {
                case '+': Tokens.Add(new Token(TokenType.PLUS, "+", L, C)); NextChar(); return true;
                case '-': Tokens.Add(new Token(TokenType.MINUS, "-", L, C)); NextChar(); return true;
                case '*': Tokens.Add(new Token(TokenType.MULTIPLY, "*", L, C)); NextChar(); return true;
                case '=': Tokens.Add(new Token(TokenType.ASSIGN, "=", L, C)); NextChar(); return true;
                case ':': Tokens.Add(new Token(TokenType.COLON, ":", L, C)); NextChar(); return true;
                case ';': Tokens.Add(new Token(TokenType.SEMICOLON, ";", L, C)); NextChar(); return true;
                case ',': Tokens.Add(new Token(TokenType.COMMA, ",", L, C)); NextChar(); return true;
                case '(': Tokens.Add(new Token(TokenType.LEFT_PAREN, "(", L, C)); NextChar(); return true;
                case ')': Tokens.Add(new Token(TokenType.RIGHT_PAREN, ")", L, C)); NextChar(); return true;
                default: return false;
            }
        }

        private char CurrentChar()
        {
            if (IsEnd()) return '\0';
            return source[position];
        }

        private void NextChar()
        {
            if (IsEnd()) return;

            if (source[position] == '\n') { line++; column = 1; }
            else { column++; }

            position++;
        }

        private bool IsEnd()
        {
            return position >= source.Length;
        }

        private void AddError(string message)
        {
            AddError(message, line, column);
        }

        private void AddError(string message, int errLine, int errColumn)
        {
            Errors.Add(new LexError(Errors.Count + 1, "Лексическая", errLine, errColumn, message));
        }
    }
}