namespace DATAO
{
    partial class EventForm
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
            this.selectWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTimeStart = new System.Windows.Forms.ComboBox();
            this.selectTimeEnd = new System.Windows.Forms.ComboBox();
            this.confirmButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectWorker
            // 
            this.selectWorker.FormattingEnabled = true;
            this.selectWorker.Location = new System.Drawing.Point(51, 161);
            this.selectWorker.Name = "selectWorker";
            this.selectWorker.Size = new System.Drawing.Size(199, 21);
            this.selectWorker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш мастер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите услугу";
            // 
            // selectService
            // 
            this.selectService.FormattingEnabled = true;
            this.selectService.Location = new System.Drawing.Point(51, 98);
            this.selectService.Name = "selectService";
            this.selectService.Size = new System.Drawing.Size(199, 21);
            this.selectService.TabIndex = 3;
            this.selectService.SelectedIndexChanged += new System.EventHandler(this.selectService_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выбранное время";
            // 
            // selectTimeStart
            // 
            this.selectTimeStart.FormattingEnabled = true;
            this.selectTimeStart.Location = new System.Drawing.Point(51, 225);
            this.selectTimeStart.Name = "selectTimeStart";
            this.selectTimeStart.Size = new System.Drawing.Size(100, 21);
            this.selectTimeStart.TabIndex = 5;
            // 
            // selectTimeEnd
            // 
            this.selectTimeEnd.FormattingEnabled = true;
            this.selectTimeEnd.Location = new System.Drawing.Point(158, 225);
            this.selectTimeEnd.Name = "selectTimeEnd";
            this.selectTimeEnd.Size = new System.Drawing.Size(92, 21);
            this.selectTimeEnd.TabIndex = 7;
            // 
            // confirmButton
            // 
            this.confirmButton.AutoSize = true;
            this.confirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmButton.Depth = 0;
            this.confirmButton.Location = new System.Drawing.Point(89, 333);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Primary = false;
            this.confirmButton.Size = new System.Drawing.Size(112, 36);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(51, 282);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(199, 20);
            this.clientName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Имя клиента";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.selectTimeEnd);
            this.Controls.Add(this.selectTimeStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectWorker);
            this.Name = "EventForm";
            this.Text = "Редактор события";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectTimeStart;
        private System.Windows.Forms.ComboBox selectTimeEnd;
        private MaterialSkin.Controls.MaterialFlatButton confirmButton;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label4;
    }
}