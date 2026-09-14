namespace tyap_brig_1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSample = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLexAnalysis = new System.Windows.Forms.ToolStripButton();
            this.btnSyntaxAnalysis = new System.Windows.Forms.ToolStripButton();
            this.btnFullAnalysis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.resultTabs = new System.Windows.Forms.TabControl();
            this.tabLexems = new System.Windows.Forms.TabPage();
            this.lexTable = new System.Windows.Forms.DataGridView();
            this.colLexNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSymbols = new System.Windows.Forms.TabPage();
            this.symTable = new System.Windows.Forms.DataGridView();
            this.colSymNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabErrors = new System.Windows.Forms.TabPage();
            this.errTable = new System.Windows.Forms.DataGridView();
            this.colErrNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAutomaton = new System.Windows.Forms.TabPage();
            this.automatonTable = new System.Windows.Forms.DataGridView();
            this.colAutoStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoStack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLexCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusErrCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPosition = new System.Windows.Forms.ToolStripStatusLabel();

            // ==================== toolStrip ====================
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnClear,
                this.toolStripSeparator1,
                this.btnSample,
                this.toolStripSeparator2,
                this.btnLexAnalysis,
                this.toolStripSeparator3,
                this.btnAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);

            // btnClear
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 21);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);

            // btnSample
            this.btnSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(55, 21);
            this.btnSample.Text = "Пример";
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);

            // toolStripSeparator2
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);

            // btnLexAnalysis
            this.btnLexAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLexAnalysis.Name = "btnLexAnalysis";
            this.btnLexAnalysis.Size = new System.Drawing.Size(120, 21);
            this.btnLexAnalysis.Text = "Лексический анализ";
            this.btnLexAnalysis.Click += new System.EventHandler(this.btnLexAnalysis_Click);

            // btnSyntaxAnalysis
            this.btnSyntaxAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSyntaxAnalysis.Name = "btnSyntaxAnalysis";
            this.btnSyntaxAnalysis.Size = new System.Drawing.Size(130, 21);
            this.btnSyntaxAnalysis.Text = "Синтаксический анализ";
            this.btnSyntaxAnalysis.Click += new System.EventHandler(this.btnSyntaxAnalysis_Click);

            // btnFullAnalysis
            this.btnFullAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFullAnalysis.Name = "btnFullAnalysis";
            this.btnFullAnalysis.Size = new System.Drawing.Size(100, 21);
            this.btnFullAnalysis.Text = "Полный анализ";
            this.btnFullAnalysis.Click += new System.EventHandler(this.btnFullAnalysis_Click);

            // toolStripSeparator3
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 21);

            // btnAbout
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 21);
            this.btnAbout.Text = "О программе";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

            // ==================== splitContainer ====================
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new System.Drawing.Size(1000, 601);
            this.splitContainer.SplitterDistance = 420;
            this.splitContainer.TabIndex = 1;

            // ==================== codeBox ====================
            this.codeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.codeBox.Location = new System.Drawing.Point(0, 0);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(420, 601);
            this.codeBox.TabIndex = 0;
            this.codeBox.Text = "";
            this.codeBox.WordWrap = false;
            this.codeBox.AcceptsTab = true;
            this.codeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.codeBox.SelectionChanged += new System.EventHandler(this.codeBox_SelectionChanged);

            // ==================== resultTabs ====================
            this.resultTabs.Controls.Add(this.tabLexems);
            this.resultTabs.Controls.Add(this.tabSymbols);
            this.resultTabs.Controls.Add(this.tabErrors);
            this.resultTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTabs.Location = new System.Drawing.Point(0, 0);
            this.resultTabs.Name = "resultTabs";
            this.resultTabs.SelectedIndex = 0;
            this.resultTabs.Size = new System.Drawing.Size(576, 601);
            this.resultTabs.TabIndex = 0;

            // ==================== tabLexems ====================
            this.tabLexems.Controls.Add(this.lexTable);
            this.tabLexems.Location = new System.Drawing.Point(4, 22);
            this.tabLexems.Name = "tabLexems";
            this.tabLexems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLexems.Size = new System.Drawing.Size(568, 575);
            this.tabLexems.TabIndex = 0;
            this.tabLexems.Text = "Лексемы";
            this.tabLexems.UseVisualStyleBackColor = true;

            // lexTable
            this.lexTable.AllowUserToAddRows = false;
            this.lexTable.AllowUserToDeleteRows = false;
            this.lexTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lexTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lexTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLexNum, this.colLexType, this.colLexCode, this.colLexValue,
                this.colLexLine, this.colLexColumn});
            this.lexTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lexTable.Location = new System.Drawing.Point(3, 3);
            this.lexTable.Name = "lexTable";
            this.lexTable.ReadOnly = true;
            this.lexTable.RowHeadersVisible = false;
            this.lexTable.Size = new System.Drawing.Size(562, 569);
            this.lexTable.TabIndex = 0;

            this.colLexNum.HeaderText = "№";
            this.colLexNum.Name = "colLexNum";
            this.colLexNum.ReadOnly = true;
            this.colLexNum.Width = 40;

            this.colLexType.HeaderText = "Тип";
            this.colLexType.Name = "colLexType";
            this.colLexType.ReadOnly = true;
            this.colLexType.Width = 120;

            this.colLexCode.HeaderText = "Код";
            this.colLexCode.Name = "colLexCode";
            this.colLexCode.ReadOnly = true;
            this.colLexCode.Width = 80;

            this.colLexValue.HeaderText = "Значение";
            this.colLexValue.Name = "colLexValue";
            this.colLexValue.ReadOnly = true;
            this.colLexValue.Width = 150;

            this.colLexLine.HeaderText = "Строка";
            this.colLexLine.Name = "colLexLine";
            this.colLexLine.ReadOnly = true;
            this.colLexLine.Width = 60;

            this.colLexColumn.HeaderText = "Столбец";
            this.colLexColumn.Name = "colLexColumn";
            this.colLexColumn.ReadOnly = true;
            this.colLexColumn.Width = 60;

            // ==================== tabSymbols ====================
            this.tabSymbols.Controls.Add(this.symTable);
            this.tabSymbols.Location = new System.Drawing.Point(4, 22);
            this.tabSymbols.Name = "tabSymbols";
            this.tabSymbols.Padding = new System.Windows.Forms.Padding(3);
            this.tabSymbols.Size = new System.Drawing.Size(568, 575);
            this.tabSymbols.TabIndex = 1;
            this.tabSymbols.Text = "Таблица символов";
            this.tabSymbols.UseVisualStyleBackColor = true;

            // symTable
            this.symTable.AllowUserToAddRows = false;
            this.symTable.AllowUserToDeleteRows = false;
            this.symTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.symTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.symTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSymNum, this.colSymName, this.colSymType,
                this.colSymValue, this.colSymAddress, this.colSymLine});
            this.symTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symTable.Location = new System.Drawing.Point(3, 3);
            this.symTable.Name = "symTable";
            this.symTable.ReadOnly = true;
            this.symTable.RowHeadersVisible = false;
            this.symTable.Size = new System.Drawing.Size(562, 569);
            this.symTable.TabIndex = 0;

            this.colSymNum.HeaderText = "№";
            this.colSymNum.Name = "colSymNum";
            this.colSymNum.ReadOnly = true;
            this.colSymNum.Width = 40;

            this.colSymName.HeaderText = "Имя";
            this.colSymName.Name = "colSymName";
            this.colSymName.ReadOnly = true;
            this.colSymName.Width = 120;

            this.colSymType.HeaderText = "Тип";
            this.colSymType.Name = "colSymType";
            this.colSymType.ReadOnly = true;
            this.colSymType.Width = 80;

            this.colSymValue.HeaderText = "Значение";
            this.colSymValue.Name = "colSymValue";
            this.colSymValue.ReadOnly = true;
            this.colSymValue.Width = 100;

            this.colSymAddress.HeaderText = "Адрес";
            this.colSymAddress.Name = "colSymAddress";
            this.colSymAddress.ReadOnly = true;
            this.colSymAddress.Width = 80;

            this.colSymLine.HeaderText = "Строка";
            this.colSymLine.Name = "colSymLine";
            this.colSymLine.ReadOnly = true;
            this.colSymLine.Width = 60;

            // ==================== tabErrors ====================
            this.tabErrors.Controls.Add(this.errTable);
            this.tabErrors.Location = new System.Drawing.Point(4, 22);
            this.tabErrors.Name = "tabErrors";
            this.tabErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrors.Size = new System.Drawing.Size(568, 575);
            this.tabErrors.TabIndex = 2;
            this.tabErrors.Text = "Ошибки";
            this.tabErrors.UseVisualStyleBackColor = true;

            // errTable
            this.errTable.AllowUserToAddRows = false;
            this.errTable.AllowUserToDeleteRows = false;
            this.errTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.errTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colErrNum, this.colErrType, this.colErrLine,
                this.colErrColumn, this.colErrMessage});
            this.errTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errTable.Location = new System.Drawing.Point(3, 3);
            this.errTable.Name = "errTable";
            this.errTable.ReadOnly = true;
            this.errTable.RowHeadersVisible = false;
            this.errTable.Size = new System.Drawing.Size(562, 569);
            this.errTable.TabIndex = 0;
            this.errTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.errTable_CellDoubleClick);

            this.colErrNum.HeaderText = "№";
            this.colErrNum.Name = "colErrNum";
            this.colErrNum.ReadOnly = true;
            this.colErrNum.Width = 40;

            this.colErrType.HeaderText = "Тип";
            this.colErrType.Name = "colErrType";
            this.colErrType.ReadOnly = true;
            this.colErrType.Width = 120;

            this.colErrLine.HeaderText = "Строка";
            this.colErrLine.Name = "colErrLine";
            this.colErrLine.ReadOnly = true;
            this.colErrLine.Width = 60;

            this.colErrColumn.HeaderText = "Столбец";
            this.colErrColumn.Name = "colErrColumn";
            this.colErrColumn.ReadOnly = true;
            this.colErrColumn.Width = 60;

            this.colErrMessage.HeaderText = "Описание";
            this.colErrMessage.Name = "colErrMessage";
            this.colErrMessage.ReadOnly = true;
            this.colErrMessage.Width = 300;

            // ==================== tabAutomaton ====================
            this.tabAutomaton.Controls.Add(this.automatonTable);
            this.tabAutomaton.Location = new System.Drawing.Point(4, 22);
            this.tabAutomaton.Name = "tabAutomaton";
            this.tabAutomaton.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomaton.Size = new System.Drawing.Size(568, 575);
            this.tabAutomaton.TabIndex = 3;
            this.tabAutomaton.Text = "Магазинный автомат";
            this.tabAutomaton.UseVisualStyleBackColor = true;

            // automatonTable
            this.automatonTable.AllowUserToAddRows = false;
            this.automatonTable.AllowUserToDeleteRows = false;
            this.automatonTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.automatonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automatonTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colAutoStep, this.colAutoState, this.colAutoStack,
                this.colAutoInput, this.colAutoAction, this.colAutoRule});
            this.automatonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.automatonTable.Location = new System.Drawing.Point(3, 3);
            this.automatonTable.Name = "automatonTable";
            this.automatonTable.ReadOnly = true;
            this.automatonTable.RowHeadersVisible = false;
            this.automatonTable.Size = new System.Drawing.Size(562, 569);
            this.automatonTable.TabIndex = 0;

            this.colAutoStep.HeaderText = "Шаг";
            this.colAutoStep.Name = "colAutoStep";
            this.colAutoStep.ReadOnly = true;
            this.colAutoStep.Width = 50;

            this.colAutoState.HeaderText = "Состояние";
            this.colAutoState.Name = "colAutoState";
            this.colAutoState.ReadOnly = true;
            this.colAutoState.Width = 80;

            this.colAutoStack.HeaderText = "Стек";
            this.colAutoStack.Name = "colAutoStack";
            this.colAutoStack.ReadOnly = true;
            this.colAutoStack.Width = 200;

            this.colAutoInput.HeaderText = "Вход";
            this.colAutoInput.Name = "colAutoInput";
            this.colAutoInput.ReadOnly = true;
            this.colAutoInput.Width = 120;

            this.colAutoAction.HeaderText = "Действие";
            this.colAutoAction.Name = "colAutoAction";
            this.colAutoAction.ReadOnly = true;
            this.colAutoAction.Width = 150;

            this.colAutoRule.HeaderText = "Правило";
            this.colAutoRule.Name = "colAutoRule";
            this.colAutoRule.ReadOnly = true;
            this.colAutoRule.Width = 120;

            // ==================== statusStrip ====================
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.statusLabel, this.statusLexCount, this.statusErrCount, this.statusPosition});
            this.statusStrip.Location = new System.Drawing.Point(0, 626);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip.TabIndex = 2;

            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 17);
            this.statusLabel.Text = "Готово";

            this.statusLexCount.Name = "statusLexCount";
            this.statusLexCount.Size = new System.Drawing.Size(80, 17);
            this.statusLexCount.Text = "Лексем: 0";

            this.statusErrCount.Name = "statusErrCount";
            this.statusErrCount.Size = new System.Drawing.Size(70, 17);
            this.statusErrCount.Text = "Ошибок: 0";

            this.statusPosition.Name = "statusPosition";
            this.statusPosition.Size = new System.Drawing.Size(80, 17);
            this.statusPosition.Text = "Строка: 1, Столбец: 1";

            // ==================== MainForm ====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 648);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транслятор языка (вариант №1)";

            // ВАЖНО: привязка контролов к панелям SplitContainer
            this.splitContainer.Panel1.Controls.Add(this.codeBox);
            this.splitContainer.Panel2.Controls.Add(this.resultTabs);

            // Завершение инициализации
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.resultTabs.SuspendLayout();
            this.tabLexems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lexTable)).BeginInit();
            this.tabSymbols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.symTable)).BeginInit();
            this.tabErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTable)).BeginInit();
            this.tabAutomaton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automatonTable)).BeginInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLexAnalysis;
        private System.Windows.Forms.ToolStripButton btnSyntaxAnalysis;
        private System.Windows.Forms.ToolStripButton btnFullAnalysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.TabControl resultTabs;
        private System.Windows.Forms.TabPage tabLexems;
        private System.Windows.Forms.DataGridView lexTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexColumn;
        private System.Windows.Forms.TabPage tabSymbols;
        private System.Windows.Forms.DataGridView symTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymLine;
        private System.Windows.Forms.TabPage tabErrors;
        private System.Windows.Forms.DataGridView errTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrMessage;
        private System.Windows.Forms.TabPage tabAutomaton;
        private System.Windows.Forms.DataGridView automatonTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoStack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoRule;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLexCount;
        private System.Windows.Forms.ToolStripStatusLabel statusErrCount;
        private System.Windows.Forms.ToolStripStatusLabel statusPosition;
    }
}