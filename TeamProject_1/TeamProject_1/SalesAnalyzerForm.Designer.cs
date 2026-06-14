namespace OrderCoffeeSystem
{
    partial class SalesAnalyzerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YearSelect = new System.Windows.Forms.ComboBox();
            this.MonthSelect = new System.Windows.Forms.ComboBox();
            this.DaySelect = new System.Windows.Forms.ComboBox();
            this.AnalyzeBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuSelect
            // 
            this.menuSelect.FormattingEnabled = true;
            this.menuSelect.Location = new System.Drawing.Point(73, 6);
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(150, 20);
            this.menuSelect.TabIndex = 0;
            this.menuSelect.SelectedIndexChanged += new System.EventHandler(this.menuSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "분석 메뉴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "날짜";
            // 
            // YearSelect
            // 
            this.YearSelect.FormattingEnabled = true;
            this.YearSelect.Location = new System.Drawing.Point(46, 33);
            this.YearSelect.Name = "YearSelect";
            this.YearSelect.Size = new System.Drawing.Size(75, 20);
            this.YearSelect.TabIndex = 3;
            // 
            // MonthSelect
            // 
            this.MonthSelect.FormattingEnabled = true;
            this.MonthSelect.Location = new System.Drawing.Point(127, 33);
            this.MonthSelect.Name = "MonthSelect";
            this.MonthSelect.Size = new System.Drawing.Size(45, 20);
            this.MonthSelect.TabIndex = 4;
            // 
            // DaySelect
            // 
            this.DaySelect.FormattingEnabled = true;
            this.DaySelect.Location = new System.Drawing.Point(178, 33);
            this.DaySelect.Name = "DaySelect";
            this.DaySelect.Size = new System.Drawing.Size(45, 20);
            this.DaySelect.TabIndex = 5;
            // 
            // AnalyzeBtn
            // 
            this.AnalyzeBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AnalyzeBtn.Location = new System.Drawing.Point(229, 6);
            this.AnalyzeBtn.Name = "AnalyzeBtn";
            this.AnalyzeBtn.Size = new System.Drawing.Size(112, 47);
            this.AnalyzeBtn.TabIndex = 6;
            this.AnalyzeBtn.Text = "분석하기";
            this.AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AnalyzeBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(13, 59);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(329, 379);
            this.resultTextBox.TabIndex = 7;
            // 
            // SalesAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.AnalyzeBtn);
            this.Controls.Add(this.DaySelect);
            this.Controls.Add(this.MonthSelect);
            this.Controls.Add(this.YearSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuSelect);
            this.Name = "SalesAnalyzerForm";
            this.Text = "SalesAnalyzer";
            this.Load += new System.EventHandler(this.SalesAnalyzerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox YearSelect;
        private System.Windows.Forms.ComboBox MonthSelect;
        private System.Windows.Forms.ComboBox DaySelect;
        private System.Windows.Forms.Button AnalyzeBtn;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}