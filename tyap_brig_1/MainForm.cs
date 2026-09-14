using System;
using System.Windows.Forms;

namespace tyap_brig_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadSampleProgram();
        }

        private void LoadSampleProgram()
        {
            codeBox.Text =
                "VAR A, B, I : INTEGER;\r\n" +
                "BEGIN\r\n" +
                "    READ(A);\r\n" +
                "    B = 0;\r\n" +
                "    FOR I = 1 TO A DO\r\n" +
                "        B = B + I;\r\n" +
                "    END_FOR;\r\n" +
                "    WRITE(B);\r\n" +
                "END";
        }

        // КНОПКИ

        private void btnClear_Click(object sender, EventArgs e) => ClearAll();
        private void btnSample_Click(object sender, EventArgs e) => LoadSampleProgram();
        private void btnLexAnalysis_Click(object sender, EventArgs e) => RunLexicalAnalysis();
        private void btnSyntaxAnalysis_Click(object sender, EventArgs e) => RunSyntaxAnalysis();
        private void btnFullAnalysis_Click(object sender, EventArgs e) => RunFullAnalysis();

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Транслятор языка (вариант №1)\n\n" +
                "Курсовая работа по дисциплине\n" +
                "«Теория языков программирования и методы трансляции»\n\n" +
                "Тип переменных: INTEGER\n" +
                "Распознаватель: LL(1) нисходящий\n" +
                "Операторы: READ, FOR, WRITE\n\n" +
                "   \n" +
                "ГРАММАТИКА ЯЗЫКА\n" +
                "   \n\n" +
                "I → A B\n" +
                "A → VAR D : INTEGER ;\n" +
                "D → E | E , D\n" +
                "B → BEGIN C END\n" +
                "C → F | F C\n" +
                "C → Q | Q C\n" +
                "C → R | R C\n" +
                "C → S | S C\n" +
                "F → E = G ;\n" +
                "G → H J | J\n" +
                "H → -\n" +
                "J → ( G ) | K | K L J\n" +
                "K → E | M\n" +
                "L → + | - | *\n" +
                "E → N E | N\n" +
                "M → P M | P\n" +
                "N → A | B | C | D | E | F | G | H | I | J | K | L | M\n" +
                "  | N | O | P | Q | R | S | T | U | V | W | X | Y | Z\n" +
                "P → 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9\n" +
                "Q → READ ( D ) ;\n" +
                "R → FOR E = G TO G DO C END_FOR ;\n" +
                "S → WRITE ( D ) ;\n\n" +
                "   \n" +
                "ОБОЗНАЧЕНИЯ НЕТЕРМИНАЛОВ\n" +
                "   \n\n" +
                "I — Программа\n" +
                "A — Объявление переменных\n" +
                "B — Описание вычислений\n" +
                "C — Список присваиваний\n" +
                "D — Список переменных\n" +
                "E — Идентификатор\n" +
                "F — Присваивание\n" +
                "G — Выражение\n" +
                "H — Унарные операции\n" +
                "J — Подвыражение\n" +
                "K — Операнд\n" +
                "L — Бинарные операции\n" +
                "M — Константа\n" +
                "N — Буква\n" +
                "P — Цифра\n" +
                "Q — READ-оператор\n" +
                "R — FOR-оператор\n" +
                "S — WRITE-оператор\n\n" +
                "",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // СОБЫТИЯ

        private void codeBox_SelectionChanged(object sender, EventArgs e)
        {
            int line = codeBox.GetLineFromCharIndex(codeBox.SelectionStart) + 1;
            int col = codeBox.SelectionStart - codeBox.GetFirstCharIndexFromLine(line - 1) + 1;
            statusPosition.Text = $"Строка: {line}, Столбец: {col}";
        }

        private void errTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string lineStr = errTable.Rows[e.RowIndex].Cells["colErrLine"].Value?.ToString();
                if (int.TryParse(lineStr, out int line))
                {
                    int index = codeBox.GetFirstCharIndexFromLine(line - 1);
                    if (index >= 0)
                    {
                        codeBox.SelectionStart = index;
                        codeBox.SelectionLength = 0;
                        codeBox.Focus();
                    }
                }
            }
        }

        // ВСПОМОГАТЕЛЬНЫЕ

        private void ClearAll()
        {
            codeBox.Clear();
            lexTable.Rows.Clear();
            symTable.Rows.Clear();
            errTable.Rows.Clear();
            automatonTable.Rows.Clear();
            statusLabel.Text = "Готово";
            statusLexCount.Text = "Лексем: 0";
            statusErrCount.Text = "Ошибок: 0";
        }

        // АНАЛИЗ 

        private void RunLexicalAnalysis()
        {
            statusLabel.Text = "Лексический анализ...";
            resultTabs.SelectedTab = tabLexems;
            Application.DoEvents();

            // Очищаем таблицы
            lexTable.Rows.Clear();
            symTable.Rows.Clear();
            errTable.Rows.Clear();

            // Создаём лексер и запускаем
            Lexer lexer = new Lexer(codeBox.Text);
            lexer.Analyze();

            // Заполняем таблицу лексем
            int n = 1;
            foreach (Token token in lexer.Tokens)
            {
                if (token.Type == TokenType.EOF)
                {
                    lexTable.Rows.Add(n++, "EOF", token.Code, "", token.Line, token.Column);
                }
                else
                {
                    lexTable.Rows.Add(n++, Lexer.GetRussianName(token.Type), 
                        token.Code, token.Value, token.Line, token.Column);
                }
            }

            // Заполняем таблицу символов
            foreach (Symbol sym in lexer.SymbolTable.Symbols)
            {
                symTable.Rows.Add(sym.Index, sym.Name, sym.Type,
                                  sym.Value, sym.Address, sym.Line);
            }

            // Заполняем таблицу ошибок
            foreach (LexError err in lexer.Errors)
            {
                errTable.Rows.Add(err.Index, err.Type, err.Line, err.Column, err.Message);
            }

            // Обновляем статус
            statusLexCount.Text = $"Лексем: {lexer.Tokens.Count}";
            statusErrCount.Text = $"Ошибок: {lexer.Errors.Count}";

            if (lexer.Errors.Count > 0)
                statusLabel.Text = $"Лексический анализ: {lexer.Errors.Count} ошибок";
            else
                statusLabel.Text = "Лексический анализ завершён успешно";
        }

        private void RunSyntaxAnalysis()
        {
            statusLabel.Text = "Синтаксический анализ пока не реализован";
            // TODO: синтаксический анализ
        }

        private void RunFullAnalysis()
        {
            RunLexicalAnalysis();
            // TODO: добавить синтаксический анализ
        }
    }
}