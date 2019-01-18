namespace DATAO
{
    partial class SetForm
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.scheduleGrid = new SourceGrid.Grid();
            this.confirmFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.actualAddressTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.nameOrgTextBox = new System.Windows.Forms.TextBox();
            this.legfalAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tinTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Телефон";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 166);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Адрес";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 203);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(42, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "ИНН";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 239);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Расч. счет";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(28, 274);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "График:";
            // 
            // scheduleGrid
            // 
            this.scheduleGrid.AutoStretchColumnsToFitWidth = true;
            this.scheduleGrid.AutoStretchRowsToFitHeight = true;
            this.scheduleGrid.EnableSort = true;
            this.scheduleGrid.Location = new System.Drawing.Point(129, 274);
            this.scheduleGrid.Name = "scheduleGrid";
            this.scheduleGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForColumns;
            this.scheduleGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.scheduleGrid.Size = new System.Drawing.Size(429, 79);
            this.scheduleGrid.TabIndex = 5;
            this.scheduleGrid.TabStop = true;
            this.scheduleGrid.ToolTipText = "";
            // 
            // confirmFlatButton
            // 
            this.confirmFlatButton.AutoSize = true;
            this.confirmFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmFlatButton.Depth = 0;
            this.confirmFlatButton.Location = new System.Drawing.Point(32, 362);
            this.confirmFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmFlatButton.Name = "confirmFlatButton";
            this.confirmFlatButton.Primary = false;
            this.confirmFlatButton.Size = new System.Drawing.Size(112, 36);
            this.confirmFlatButton.TabIndex = 6;
            this.confirmFlatButton.Text = "Подтвердить";
            this.confirmFlatButton.UseVisualStyleBackColor = true;
            this.confirmFlatButton.Click += new System.EventHandler(this.confirmlFlatButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(129, 119);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(429, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // actualAddressTextBox
            // 
            this.actualAddressTextBox.Location = new System.Drawing.Point(129, 164);
            this.actualAddressTextBox.Name = "actualAddressTextBox";
            this.actualAddressTextBox.Size = new System.Drawing.Size(194, 20);
            this.actualAddressTextBox.TabIndex = 8;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(28, 86);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Название";
            // 
            // nameOrgTextBox
            // 
            this.nameOrgTextBox.Location = new System.Drawing.Point(129, 85);
            this.nameOrgTextBox.Name = "nameOrgTextBox";
            this.nameOrgTextBox.Size = new System.Drawing.Size(429, 20);
            this.nameOrgTextBox.TabIndex = 12;
            // 
            // legfalAddressTextBox
            // 
            this.legfalAddressTextBox.Location = new System.Drawing.Point(330, 164);
            this.legfalAddressTextBox.Name = "legfalAddressTextBox";
            this.legfalAddressTextBox.Size = new System.Drawing.Size(228, 20);
            this.legfalAddressTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фактический";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Юридический";
            // 
            // tinTextBox
            // 
            this.tinTextBox.Location = new System.Drawing.Point(129, 203);
            this.tinTextBox.Name = "tinTextBox";
            this.tinTextBox.Size = new System.Drawing.Size(429, 20);
            this.tinTextBox.TabIndex = 9;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(129, 238);
            this.accountNumberTextBox.Mask = "00000000000000000000";
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(429, 20);
            this.accountNumberTextBox.TabIndex = 16;
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 422);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legfalAddressTextBox);
            this.Controls.Add(this.nameOrgTextBox);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tinTextBox);
            this.Controls.Add(this.actualAddressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.confirmFlatButton);
            this.Controls.Add(this.scheduleGrid);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SetForm";
            this.Text = "Настройки салона";
            this.Load += new System.EventHandler(this.SetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private SourceGrid.Grid scheduleGrid;
        private MaterialSkin.Controls.MaterialFlatButton confirmFlatButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox actualAddressTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox nameOrgTextBox;
        private System.Windows.Forms.TextBox legfalAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tinTextBox;
        private System.Windows.Forms.MaskedTextBox accountNumberTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}