namespace DATAO
{
    partial class ReportForm
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
            this.reportTypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.saveReportButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.spendTextBox = new System.Windows.Forms.TextBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // reportTypeComboBox1
            // 
            this.reportTypeComboBox1.FormattingEnabled = true;
            this.reportTypeComboBox1.Items.AddRange(new object[] {
            "Зарплаты за последний месяц",
            "Авансовый платеж за 3 месяца",
            "Годовой отчет по УСН ИП"});
            this.reportTypeComboBox1.Location = new System.Drawing.Point(74, 98);
            this.reportTypeComboBox1.Name = "reportTypeComboBox1";
            this.reportTypeComboBox1.Size = new System.Drawing.Size(211, 21);
            this.reportTypeComboBox1.TabIndex = 0;
            this.reportTypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.reportTypeComboBox1_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(134, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Тип отчета";
            // 
            // saveReportButton
            // 
            this.saveReportButton.Depth = 0;
            this.saveReportButton.Location = new System.Drawing.Point(98, 374);
            this.saveReportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Primary = true;
            this.saveReportButton.Size = new System.Drawing.Size(147, 35);
            this.saveReportButton.TabIndex = 2;
            this.saveReportButton.Text = "Составить";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // profitTextBox
            // 
            this.profitTextBox.Location = new System.Drawing.Point(121, 173);
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.Size = new System.Drawing.Size(100, 20);
            this.profitTextBox.TabIndex = 3;
            // 
            // spendTextBox
            // 
            this.spendTextBox.Location = new System.Drawing.Point(121, 233);
            this.spendTextBox.Name = "spendTextBox";
            this.spendTextBox.Size = new System.Drawing.Size(100, 20);
            this.spendTextBox.TabIndex = 4;
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(121, 294);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(100, 20);
            this.payTextBox.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(144, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Доход";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(139, 211);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Расход";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(97, 272);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(148, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Авансовый платеж";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 433);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.payTextBox);
            this.Controls.Add(this.spendTextBox);
            this.Controls.Add(this.profitTextBox);
            this.Controls.Add(this.saveReportButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.reportTypeComboBox1);
            this.Name = "ReportForm";
            this.Text = "Параметры отчета";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportTypeComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton saveReportButton;
        private System.Windows.Forms.TextBox profitTextBox;
        private System.Windows.Forms.TextBox spendTextBox;
        private System.Windows.Forms.TextBox payTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}