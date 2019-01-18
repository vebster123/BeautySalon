using System.Windows.Forms;

namespace DATAO
{
    partial class AdminForm
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
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.checkConfirmButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label14 = new System.Windows.Forms.Label();
            this.costEventTextBox = new System.Windows.Forms.TextBox();
            this.deleteEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ScheduleGrid = new SourceGrid.Grid();
            this.checkEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Personal = new System.Windows.Forms.TabPage();
            this.saveChangePersonalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editPersonalCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.newPersonalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.personalListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endPersonalDayView = new System.Windows.Forms.Label();
            this.startPersonalDayView = new System.Windows.Forms.Label();
            this.statusPeronalLabel = new System.Windows.Forms.Label();
            this.addressPeronalLabel = new System.Windows.Forms.Label();
            this.ratePeronalLabel = new System.Windows.Forms.Label();
            this.phonePeronalLabel = new System.Windows.Forms.Label();
            this.namePeronalLabel = new System.Windows.Forms.Label();
            this.endPersonalDay = new System.Windows.Forms.MaskedTextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.startPersonalDay = new System.Windows.Forms.MaskedTextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phonePersonalTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendarPersonal = new System.Windows.Forms.MonthCalendar();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Uslugi = new System.Windows.Forms.TabPage();
            this.newServiceBox = new System.Windows.Forms.GroupBox();
            this.newTimeServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newCostServiceTextBox = new System.Windows.Forms.TextBox();
            this.newNameServiceTextBox = new System.Windows.Forms.TextBox();
            this.saveServiceButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newServiceButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rightButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.leftButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numberPageLabel = new System.Windows.Forms.Label();
            this.serviceBox3 = new System.Windows.Forms.GroupBox();
            this.costCurrentService3 = new System.Windows.Forms.TextBox();
            this.deleteServicePicture3 = new System.Windows.Forms.PictureBox();
            this.changePicture3 = new System.Windows.Forms.PictureBox();
            this.timeService3 = new System.Windows.Forms.Label();
            this.costService3 = new System.Windows.Forms.Label();
            this.nameServiceLabel3 = new System.Windows.Forms.Label();
            this.serviceBox2 = new System.Windows.Forms.GroupBox();
            this.costCurrentService2 = new System.Windows.Forms.TextBox();
            this.deleteServicePicture2 = new System.Windows.Forms.PictureBox();
            this.changePicture2 = new System.Windows.Forms.PictureBox();
            this.timeService2 = new System.Windows.Forms.Label();
            this.costService2 = new System.Windows.Forms.Label();
            this.nameServiceLabel2 = new System.Windows.Forms.Label();
            this.serviceBox1 = new System.Windows.Forms.GroupBox();
            this.costCurrentService1 = new System.Windows.Forms.TextBox();
            this.deleteServicePicture1 = new System.Windows.Forms.PictureBox();
            this.changePicture1 = new System.Windows.Forms.PictureBox();
            this.timeService1 = new System.Windows.Forms.Label();
            this.costService1 = new System.Windows.Forms.Label();
            this.nameServiceLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statService = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceEndDate = new System.Windows.Forms.DateTimePicker();
            this.serviceStartDate = new System.Windows.Forms.DateTimePicker();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serviceBox = new System.Windows.Forms.GroupBox();
            this.costCurrentService = new System.Windows.Forms.TextBox();
            this.deleteServicePicture = new System.Windows.Forms.PictureBox();
            this.changePicture = new System.Windows.Forms.PictureBox();
            this.timeService = new System.Windows.Forms.Label();
            this.costService = new System.Windows.Forms.Label();
            this.nameServiceLabel = new System.Windows.Forms.Label();
            this.Sklad = new System.Windows.Forms.TabPage();
            this.completeIncomeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.syncSkladButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.skladGrid = new SourceGrid.Grid();
            this.searchValueSkladtextBox = new System.Windows.Forms.TextBox();
            this.statisticsSkladBox = new System.Windows.Forms.GroupBox();
            this.confirmIncomeRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateIncome = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.costIncometextBox4 = new System.Windows.Forms.TextBox();
            this.providerIncometextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchSkladBox = new System.Windows.Forms.GroupBox();
            this.searchSkladShowButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteFromSkladPictureBox = new System.Windows.Forms.PictureBox();
            this.addToSkladPictureBox = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.settingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.reportRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.Personal.SuspendLayout();
            this.groupBoxPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Uslugi.SuspendLayout();
            this.newServiceBox.SuspendLayout();
            this.serviceBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture3)).BeginInit();
            this.serviceBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture2)).BeginInit();
            this.serviceBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.serviceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture)).BeginInit();
            this.Sklad.SuspendLayout();
            this.statisticsSkladBox.SuspendLayout();
            this.searchSkladBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromSkladPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToSkladPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Personal);
            this.tabControl.Controls.Add(this.Uslugi);
            this.tabControl.Controls.Add(this.Sklad);
            this.tabControl.Depth = 0;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(-1, 121);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1281, 600);
            this.tabControl.TabIndex = 2;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calendar.Controls.Add(this.checkConfirmButton);
            this.Calendar.Controls.Add(this.label14);
            this.Calendar.Controls.Add(this.costEventTextBox);
            this.Calendar.Controls.Add(this.deleteEventButton);
            this.Calendar.Controls.Add(this.ScheduleGrid);
            this.Calendar.Controls.Add(this.checkEventButton);
            this.Calendar.Controls.Add(this.AddEventButton);
            this.Calendar.Controls.Add(this.monthCalendar);
            this.Calendar.Location = new System.Drawing.Point(4, 22);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar.Size = new System.Drawing.Size(1273, 574);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Календарь";
            // 
            // checkConfirmButton
            // 
            this.checkConfirmButton.Depth = 0;
            this.checkConfirmButton.Location = new System.Drawing.Point(25, 441);
            this.checkConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkConfirmButton.Name = "checkConfirmButton";
            this.checkConfirmButton.Primary = true;
            this.checkConfirmButton.Size = new System.Drawing.Size(164, 37);
            this.checkConfirmButton.TabIndex = 8;
            this.checkConfirmButton.Text = "подтвердить";
            this.checkConfirmButton.UseVisualStyleBackColor = true;
            this.checkConfirmButton.Visible = false;
            this.checkConfirmButton.Click += new System.EventHandler(this.checkConfirmButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(9, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "к оплате (если хотите изменить цену)";
            this.label14.Visible = false;
            // 
            // costEventTextBox
            // 
            this.costEventTextBox.Location = new System.Drawing.Point(58, 412);
            this.costEventTextBox.Name = "costEventTextBox";
            this.costEventTextBox.Size = new System.Drawing.Size(100, 20);
            this.costEventTextBox.TabIndex = 6;
            this.costEventTextBox.Visible = false;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Depth = 0;
            this.deleteEventButton.Location = new System.Drawing.Point(25, 279);
            this.deleteEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Primary = true;
            this.deleteEventButton.Size = new System.Drawing.Size(164, 39);
            this.deleteEventButton.TabIndex = 5;
            this.deleteEventButton.Text = "Удалить";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // ScheduleGrid
            // 
            this.ScheduleGrid.AutoSize = true;
            this.ScheduleGrid.AutoStretchColumnsToFitWidth = true;
            this.ScheduleGrid.AutoStretchRowsToFitHeight = true;
            this.ScheduleGrid.EnableSort = true;
            this.ScheduleGrid.Location = new System.Drawing.Point(220, 27);
            this.ScheduleGrid.Name = "ScheduleGrid";
            this.ScheduleGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.ScheduleGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.ScheduleGrid.Size = new System.Drawing.Size(1027, 507);
            this.ScheduleGrid.TabIndex = 4;
            this.ScheduleGrid.TabStop = true;
            this.ScheduleGrid.ToolTipText = "";
            this.ScheduleGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScheduleGrid_MouseClick);
            // 
            // checkEventButton
            // 
            this.checkEventButton.Depth = 0;
            this.checkEventButton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEventButton.Location = new System.Drawing.Point(25, 337);
            this.checkEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkEventButton.Name = "checkEventButton";
            this.checkEventButton.Primary = true;
            this.checkEventButton.Size = new System.Drawing.Size(164, 38);
            this.checkEventButton.TabIndex = 3;
            this.checkEventButton.Text = "Выдать чек";
            this.checkEventButton.UseVisualStyleBackColor = true;
            this.checkEventButton.Click += new System.EventHandler(this.checkEventButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Depth = 0;
            this.AddEventButton.Location = new System.Drawing.Point(25, 219);
            this.AddEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Primary = true;
            this.AddEventButton.Size = new System.Drawing.Size(164, 39);
            this.AddEventButton.TabIndex = 2;
            this.AddEventButton.Text = "Настройка визита";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(25, 27);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Personal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Personal.Controls.Add(this.saveChangePersonalButton);
            this.Personal.Controls.Add(this.editPersonalCheckBox);
            this.Personal.Controls.Add(this.newPersonalButton);
            this.Personal.Controls.Add(this.personalListBox);
            this.Personal.Controls.Add(this.groupBoxPersonal);
            this.Personal.Location = new System.Drawing.Point(4, 22);
            this.Personal.Name = "Personal";
            this.Personal.Padding = new System.Windows.Forms.Padding(3);
            this.Personal.Size = new System.Drawing.Size(1273, 574);
            this.Personal.TabIndex = 1;
            this.Personal.Text = "Персонал";
            // 
            // saveChangePersonalButton
            // 
            this.saveChangePersonalButton.Depth = 0;
            this.saveChangePersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangePersonalButton.Location = new System.Drawing.Point(135, 496);
            this.saveChangePersonalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChangePersonalButton.Name = "saveChangePersonalButton";
            this.saveChangePersonalButton.Primary = true;
            this.saveChangePersonalButton.Size = new System.Drawing.Size(111, 54);
            this.saveChangePersonalButton.TabIndex = 21;
            this.saveChangePersonalButton.Text = "Сохранить";
            this.saveChangePersonalButton.UseVisualStyleBackColor = true;
            this.saveChangePersonalButton.Click += new System.EventHandler(this.saveChangePersonalButton_Click);
            // 
            // editPersonalCheckBox
            // 
            this.editPersonalCheckBox.AutoSize = true;
            this.editPersonalCheckBox.Depth = 0;
            this.editPersonalCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.editPersonalCheckBox.ForeColor = System.Drawing.Color.White;
            this.editPersonalCheckBox.Location = new System.Drawing.Point(1058, 36);
            this.editPersonalCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.editPersonalCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.editPersonalCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.editPersonalCheckBox.Name = "editPersonalCheckBox";
            this.editPersonalCheckBox.Ripple = true;
            this.editPersonalCheckBox.Size = new System.Drawing.Size(186, 30);
            this.editPersonalCheckBox.TabIndex = 20;
            this.editPersonalCheckBox.Text = "Режим редактирования";
            this.editPersonalCheckBox.UseVisualStyleBackColor = true;
            this.editPersonalCheckBox.CheckedChanged += new System.EventHandler(this.editPersonalCheckBox_CheckedChanged);
            // 
            // newPersonalButton
            // 
            this.newPersonalButton.Depth = 0;
            this.newPersonalButton.Location = new System.Drawing.Point(20, 496);
            this.newPersonalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPersonalButton.Name = "newPersonalButton";
            this.newPersonalButton.Primary = true;
            this.newPersonalButton.Size = new System.Drawing.Size(109, 54);
            this.newPersonalButton.TabIndex = 3;
            this.newPersonalButton.Text = "Добавить рабочего";
            this.newPersonalButton.UseVisualStyleBackColor = true;
            this.newPersonalButton.Click += new System.EventHandler(this.newPersonalButton_Click);
            // 
            // personalListBox
            // 
            this.personalListBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.personalListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.personalListBox.FormattingEnabled = true;
            this.personalListBox.ItemHeight = 24;
            this.personalListBox.Location = new System.Drawing.Point(20, 25);
            this.personalListBox.Name = "personalListBox";
            this.personalListBox.Size = new System.Drawing.Size(226, 460);
            this.personalListBox.TabIndex = 1;
            this.personalListBox.SelectedIndexChanged += new System.EventHandler(this.personalListBox_SelectedIndexChanged);
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.pictureBox1);
            this.groupBoxPersonal.Controls.Add(this.endPersonalDayView);
            this.groupBoxPersonal.Controls.Add(this.startPersonalDayView);
            this.groupBoxPersonal.Controls.Add(this.statusPeronalLabel);
            this.groupBoxPersonal.Controls.Add(this.addressPeronalLabel);
            this.groupBoxPersonal.Controls.Add(this.ratePeronalLabel);
            this.groupBoxPersonal.Controls.Add(this.phonePeronalLabel);
            this.groupBoxPersonal.Controls.Add(this.namePeronalLabel);
            this.groupBoxPersonal.Controls.Add(this.endPersonalDay);
            this.groupBoxPersonal.Controls.Add(this.statusTextBox);
            this.groupBoxPersonal.Controls.Add(this.startPersonalDay);
            this.groupBoxPersonal.Controls.Add(this.rateTextBox);
            this.groupBoxPersonal.Controls.Add(this.addressTextBox);
            this.groupBoxPersonal.Controls.Add(this.phonePersonalTextBox);
            this.groupBoxPersonal.Controls.Add(this.monthCalendarPersonal);
            this.groupBoxPersonal.Controls.Add(this.nameTextBox);
            this.groupBoxPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPersonal.Location = new System.Drawing.Point(281, 76);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Size = new System.Drawing.Size(969, 334);
            this.groupBoxPersonal.TabIndex = 11;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Информация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DATAO.Properties.Resources._40599;
            this.pictureBox1.Location = new System.Drawing.Point(689, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 269);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // endPersonalDayView
            // 
            this.endPersonalDayView.AutoSize = true;
            this.endPersonalDayView.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPersonalDayView.Location = new System.Drawing.Point(512, 178);
            this.endPersonalDayView.Name = "endPersonalDayView";
            this.endPersonalDayView.Size = new System.Drawing.Size(106, 36);
            this.endPersonalDayView.TabIndex = 33;
            this.endPersonalDayView.Text = "до --:--";
            // 
            // startPersonalDayView
            // 
            this.startPersonalDayView.AutoSize = true;
            this.startPersonalDayView.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPersonalDayView.Location = new System.Drawing.Point(532, 135);
            this.startPersonalDayView.Name = "startPersonalDayView";
            this.startPersonalDayView.Size = new System.Drawing.Size(85, 36);
            this.startPersonalDayView.TabIndex = 32;
            this.startPersonalDayView.Text = "с --:--";
            // 
            // statusPeronalLabel
            // 
            this.statusPeronalLabel.AutoSize = true;
            this.statusPeronalLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPeronalLabel.Location = new System.Drawing.Point(54, 239);
            this.statusPeronalLabel.Name = "statusPeronalLabel";
            this.statusPeronalLabel.Size = new System.Drawing.Size(49, 18);
            this.statusPeronalLabel.TabIndex = 31;
            this.statusPeronalLabel.Text = "Статус";
            // 
            // addressPeronalLabel
            // 
            this.addressPeronalLabel.AutoSize = true;
            this.addressPeronalLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressPeronalLabel.Location = new System.Drawing.Point(54, 169);
            this.addressPeronalLabel.Name = "addressPeronalLabel";
            this.addressPeronalLabel.Size = new System.Drawing.Size(46, 18);
            this.addressPeronalLabel.TabIndex = 30;
            this.addressPeronalLabel.Text = "Адрес";
            // 
            // ratePeronalLabel
            // 
            this.ratePeronalLabel.AutoSize = true;
            this.ratePeronalLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratePeronalLabel.Location = new System.Drawing.Point(54, 204);
            this.ratePeronalLabel.Name = "ratePeronalLabel";
            this.ratePeronalLabel.Size = new System.Drawing.Size(49, 18);
            this.ratePeronalLabel.TabIndex = 29;
            this.ratePeronalLabel.Text = "Ставка";
            // 
            // phonePeronalLabel
            // 
            this.phonePeronalLabel.AutoSize = true;
            this.phonePeronalLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonePeronalLabel.Location = new System.Drawing.Point(38, 134);
            this.phonePeronalLabel.Name = "phonePeronalLabel";
            this.phonePeronalLabel.Size = new System.Drawing.Size(65, 18);
            this.phonePeronalLabel.TabIndex = 28;
            this.phonePeronalLabel.Text = "Телефон";
            // 
            // namePeronalLabel
            // 
            this.namePeronalLabel.AutoSize = true;
            this.namePeronalLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePeronalLabel.Location = new System.Drawing.Point(8, 97);
            this.namePeronalLabel.Name = "namePeronalLabel";
            this.namePeronalLabel.Size = new System.Drawing.Size(95, 18);
            this.namePeronalLabel.TabIndex = 27;
            this.namePeronalLabel.Text = "Имя Фамилия";
            // 
            // endPersonalDay
            // 
            this.endPersonalDay.Location = new System.Drawing.Point(582, 222);
            this.endPersonalDay.Mask = "00:00";
            this.endPersonalDay.Name = "endPersonalDay";
            this.endPersonalDay.Size = new System.Drawing.Size(56, 20);
            this.endPersonalDay.TabIndex = 24;
            this.endPersonalDay.ValidatingType = typeof(System.DateTime);
            this.endPersonalDay.Visible = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(109, 237);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(182, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // startPersonalDay
            // 
            this.startPersonalDay.Location = new System.Drawing.Point(580, 112);
            this.startPersonalDay.Mask = "00:00";
            this.startPersonalDay.Name = "startPersonalDay";
            this.startPersonalDay.Size = new System.Drawing.Size(56, 20);
            this.startPersonalDay.TabIndex = 23;
            this.startPersonalDay.ValidatingType = typeof(System.DateTime);
            this.startPersonalDay.Visible = false;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(109, 202);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.ReadOnly = true;
            this.rateTextBox.Size = new System.Drawing.Size(182, 20);
            this.rateTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(109, 167);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(182, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // phonePersonalTextBox
            // 
            this.phonePersonalTextBox.Location = new System.Drawing.Point(109, 132);
            this.phonePersonalTextBox.Name = "phonePersonalTextBox";
            this.phonePersonalTextBox.ReadOnly = true;
            this.phonePersonalTextBox.Size = new System.Drawing.Size(182, 20);
            this.phonePersonalTextBox.TabIndex = 11;
            // 
            // monthCalendarPersonal
            // 
            this.monthCalendarPersonal.Location = new System.Drawing.Point(335, 96);
            this.monthCalendarPersonal.Name = "monthCalendarPersonal";
            this.monthCalendarPersonal.TabIndex = 22;
            this.monthCalendarPersonal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarPersonal_DateChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // Uslugi
            // 
            this.Uslugi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Uslugi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Uslugi.Controls.Add(this.newServiceBox);
            this.Uslugi.Controls.Add(this.saveServiceButton);
            this.Uslugi.Controls.Add(this.newServiceButton);
            this.Uslugi.Controls.Add(this.rightButton);
            this.Uslugi.Controls.Add(this.leftButton);
            this.Uslugi.Controls.Add(this.numberPageLabel);
            this.Uslugi.Controls.Add(this.serviceBox3);
            this.Uslugi.Controls.Add(this.serviceBox2);
            this.Uslugi.Controls.Add(this.serviceBox1);
            this.Uslugi.Controls.Add(this.groupBox1);
            this.Uslugi.Controls.Add(this.serviceBox);
            this.Uslugi.Location = new System.Drawing.Point(4, 22);
            this.Uslugi.Name = "Uslugi";
            this.Uslugi.Size = new System.Drawing.Size(1273, 574);
            this.Uslugi.TabIndex = 2;
            this.Uslugi.Text = "Услуги";
            // 
            // newServiceBox
            // 
            this.newServiceBox.Controls.Add(this.newTimeServiceComboBox);
            this.newServiceBox.Controls.Add(this.label11);
            this.newServiceBox.Controls.Add(this.label10);
            this.newServiceBox.Controls.Add(this.label9);
            this.newServiceBox.Controls.Add(this.newCostServiceTextBox);
            this.newServiceBox.Controls.Add(this.newNameServiceTextBox);
            this.newServiceBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newServiceBox.Location = new System.Drawing.Point(635, 382);
            this.newServiceBox.Name = "newServiceBox";
            this.newServiceBox.Size = new System.Drawing.Size(235, 136);
            this.newServiceBox.TabIndex = 10;
            this.newServiceBox.TabStop = false;
            this.newServiceBox.Text = "Новая услуга";
            this.newServiceBox.Visible = false;
            // 
            // newTimeServiceComboBox
            // 
            this.newTimeServiceComboBox.FormattingEnabled = true;
            this.newTimeServiceComboBox.Items.AddRange(new object[] {
            "30 минут",
            "1 час",
            "1 час 30 минут",
            "2 часа"});
            this.newTimeServiceComboBox.Location = new System.Drawing.Point(82, 92);
            this.newTimeServiceComboBox.Name = "newTimeServiceComboBox";
            this.newTimeServiceComboBox.Size = new System.Drawing.Size(132, 21);
            this.newTimeServiceComboBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Интервал";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Стоимость";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Название";
            // 
            // newCostServiceTextBox
            // 
            this.newCostServiceTextBox.Location = new System.Drawing.Point(82, 60);
            this.newCostServiceTextBox.Name = "newCostServiceTextBox";
            this.newCostServiceTextBox.Size = new System.Drawing.Size(132, 20);
            this.newCostServiceTextBox.TabIndex = 1;
            // 
            // newNameServiceTextBox
            // 
            this.newNameServiceTextBox.Location = new System.Drawing.Point(82, 25);
            this.newNameServiceTextBox.Name = "newNameServiceTextBox";
            this.newNameServiceTextBox.Size = new System.Drawing.Size(132, 20);
            this.newNameServiceTextBox.TabIndex = 0;
            // 
            // saveServiceButton
            // 
            this.saveServiceButton.Depth = 0;
            this.saveServiceButton.Location = new System.Drawing.Point(921, 436);
            this.saveServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveServiceButton.Name = "saveServiceButton";
            this.saveServiceButton.Primary = true;
            this.saveServiceButton.Size = new System.Drawing.Size(115, 34);
            this.saveServiceButton.TabIndex = 9;
            this.saveServiceButton.Text = "Сохранить";
            this.saveServiceButton.UseVisualStyleBackColor = true;
            this.saveServiceButton.Visible = false;
            this.saveServiceButton.Click += new System.EventHandler(this.saveServiceButton_Click);
            // 
            // newServiceButton
            // 
            this.newServiceButton.Depth = 0;
            this.newServiceButton.Location = new System.Drawing.Point(921, 396);
            this.newServiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newServiceButton.Name = "newServiceButton";
            this.newServiceButton.Primary = true;
            this.newServiceButton.Size = new System.Drawing.Size(115, 34);
            this.newServiceButton.TabIndex = 8;
            this.newServiceButton.Text = "Новая услуга";
            this.newServiceButton.UseVisualStyleBackColor = true;
            this.newServiceButton.Click += new System.EventHandler(this.newServiceButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Depth = 0;
            this.rightButton.Location = new System.Drawing.Point(1150, 394);
            this.rightButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightButton.Name = "rightButton";
            this.rightButton.Primary = true;
            this.rightButton.Size = new System.Drawing.Size(58, 34);
            this.rightButton.TabIndex = 7;
            this.rightButton.Text = "->";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Depth = 0;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(1051, 394);
            this.leftButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.leftButton.Name = "leftButton";
            this.leftButton.Primary = true;
            this.leftButton.Size = new System.Drawing.Size(57, 34);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "<-";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // numberPageLabel
            // 
            this.numberPageLabel.AutoSize = true;
            this.numberPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberPageLabel.Location = new System.Drawing.Point(1114, 396);
            this.numberPageLabel.Name = "numberPageLabel";
            this.numberPageLabel.Size = new System.Drawing.Size(33, 37);
            this.numberPageLabel.TabIndex = 5;
            this.numberPageLabel.Text = "1";
            // 
            // serviceBox3
            // 
            this.serviceBox3.Controls.Add(this.costCurrentService3);
            this.serviceBox3.Controls.Add(this.deleteServicePicture3);
            this.serviceBox3.Controls.Add(this.changePicture3);
            this.serviceBox3.Controls.Add(this.timeService3);
            this.serviceBox3.Controls.Add(this.costService3);
            this.serviceBox3.Controls.Add(this.nameServiceLabel3);
            this.serviceBox3.Location = new System.Drawing.Point(949, 61);
            this.serviceBox3.Name = "serviceBox3";
            this.serviceBox3.Size = new System.Drawing.Size(281, 264);
            this.serviceBox3.TabIndex = 4;
            this.serviceBox3.TabStop = false;
            this.serviceBox3.Visible = false;
            // 
            // costCurrentService3
            // 
            this.costCurrentService3.Location = new System.Drawing.Point(195, 151);
            this.costCurrentService3.Name = "costCurrentService3";
            this.costCurrentService3.Size = new System.Drawing.Size(71, 20);
            this.costCurrentService3.TabIndex = 11;
            this.costCurrentService3.Visible = false;
            // 
            // deleteServicePicture3
            // 
            this.deleteServicePicture3.BackgroundImage = global::DATAO.Properties.Resources.deleteservice;
            this.deleteServicePicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteServicePicture3.InitialImage = null;
            this.deleteServicePicture3.Location = new System.Drawing.Point(236, 23);
            this.deleteServicePicture3.Name = "deleteServicePicture3";
            this.deleteServicePicture3.Size = new System.Drawing.Size(30, 29);
            this.deleteServicePicture3.TabIndex = 4;
            this.deleteServicePicture3.TabStop = false;
            this.deleteServicePicture3.Click += new System.EventHandler(this.deleteServicePicture3_Click);
            // 
            // changePicture3
            // 
            this.changePicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePicture3.Image = global::DATAO.Properties.Resources.changeservice;
            this.changePicture3.Location = new System.Drawing.Point(18, 19);
            this.changePicture3.Name = "changePicture3";
            this.changePicture3.Size = new System.Drawing.Size(40, 40);
            this.changePicture3.TabIndex = 3;
            this.changePicture3.TabStop = false;
            this.changePicture3.Click += new System.EventHandler(this.changePicture3_Click);
            // 
            // timeService3
            // 
            this.timeService3.AutoSize = true;
            this.timeService3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeService3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeService3.Location = new System.Drawing.Point(14, 202);
            this.timeService3.Name = "timeService3";
            this.timeService3.Size = new System.Drawing.Size(140, 24);
            this.timeService3.TabIndex = 2;
            this.timeService3.Text = "Длительность";
            // 
            // costService3
            // 
            this.costService3.AutoSize = true;
            this.costService3.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costService3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.costService3.Location = new System.Drawing.Point(8, 139);
            this.costService3.Name = "costService3";
            this.costService3.Size = new System.Drawing.Size(180, 38);
            this.costService3.TabIndex = 1;
            this.costService3.Text = "Стоимость";
            // 
            // nameServiceLabel3
            // 
            this.nameServiceLabel3.AutoEllipsis = true;
            this.nameServiceLabel3.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameServiceLabel3.ForeColor = System.Drawing.Color.Orange;
            this.nameServiceLabel3.Location = new System.Drawing.Point(6, 74);
            this.nameServiceLabel3.Name = "nameServiceLabel3";
            this.nameServiceLabel3.Size = new System.Drawing.Size(260, 42);
            this.nameServiceLabel3.TabIndex = 0;
            this.nameServiceLabel3.Text = "Название";
            // 
            // serviceBox2
            // 
            this.serviceBox2.Controls.Add(this.costCurrentService2);
            this.serviceBox2.Controls.Add(this.deleteServicePicture2);
            this.serviceBox2.Controls.Add(this.changePicture2);
            this.serviceBox2.Controls.Add(this.timeService2);
            this.serviceBox2.Controls.Add(this.costService2);
            this.serviceBox2.Controls.Add(this.nameServiceLabel2);
            this.serviceBox2.Location = new System.Drawing.Point(649, 61);
            this.serviceBox2.Name = "serviceBox2";
            this.serviceBox2.Size = new System.Drawing.Size(281, 264);
            this.serviceBox2.TabIndex = 3;
            this.serviceBox2.TabStop = false;
            this.serviceBox2.Visible = false;
            // 
            // costCurrentService2
            // 
            this.costCurrentService2.Location = new System.Drawing.Point(195, 151);
            this.costCurrentService2.Name = "costCurrentService2";
            this.costCurrentService2.Size = new System.Drawing.Size(71, 20);
            this.costCurrentService2.TabIndex = 11;
            this.costCurrentService2.Visible = false;
            // 
            // deleteServicePicture2
            // 
            this.deleteServicePicture2.BackgroundImage = global::DATAO.Properties.Resources.deleteservice;
            this.deleteServicePicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteServicePicture2.InitialImage = null;
            this.deleteServicePicture2.Location = new System.Drawing.Point(236, 23);
            this.deleteServicePicture2.Name = "deleteServicePicture2";
            this.deleteServicePicture2.Size = new System.Drawing.Size(30, 29);
            this.deleteServicePicture2.TabIndex = 4;
            this.deleteServicePicture2.TabStop = false;
            this.deleteServicePicture2.Click += new System.EventHandler(this.deleteServicePicture2_Click);
            // 
            // changePicture2
            // 
            this.changePicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePicture2.Image = global::DATAO.Properties.Resources.changeservice;
            this.changePicture2.Location = new System.Drawing.Point(18, 19);
            this.changePicture2.Name = "changePicture2";
            this.changePicture2.Size = new System.Drawing.Size(40, 40);
            this.changePicture2.TabIndex = 3;
            this.changePicture2.TabStop = false;
            this.changePicture2.Click += new System.EventHandler(this.changePicture2_Click);
            // 
            // timeService2
            // 
            this.timeService2.AutoSize = true;
            this.timeService2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeService2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeService2.Location = new System.Drawing.Point(14, 202);
            this.timeService2.Name = "timeService2";
            this.timeService2.Size = new System.Drawing.Size(140, 24);
            this.timeService2.TabIndex = 2;
            this.timeService2.Text = "Длительность";
            // 
            // costService2
            // 
            this.costService2.AutoSize = true;
            this.costService2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costService2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.costService2.Location = new System.Drawing.Point(8, 139);
            this.costService2.Name = "costService2";
            this.costService2.Size = new System.Drawing.Size(180, 38);
            this.costService2.TabIndex = 1;
            this.costService2.Text = "Стоимость";
            // 
            // nameServiceLabel2
            // 
            this.nameServiceLabel2.AutoEllipsis = true;
            this.nameServiceLabel2.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameServiceLabel2.ForeColor = System.Drawing.Color.Orange;
            this.nameServiceLabel2.Location = new System.Drawing.Point(6, 73);
            this.nameServiceLabel2.Name = "nameServiceLabel2";
            this.nameServiceLabel2.Size = new System.Drawing.Size(269, 42);
            this.nameServiceLabel2.TabIndex = 0;
            this.nameServiceLabel2.Text = "Название";
            // 
            // serviceBox1
            // 
            this.serviceBox1.Controls.Add(this.costCurrentService1);
            this.serviceBox1.Controls.Add(this.deleteServicePicture1);
            this.serviceBox1.Controls.Add(this.changePicture1);
            this.serviceBox1.Controls.Add(this.timeService1);
            this.serviceBox1.Controls.Add(this.costService1);
            this.serviceBox1.Controls.Add(this.nameServiceLabel1);
            this.serviceBox1.Location = new System.Drawing.Point(349, 61);
            this.serviceBox1.Name = "serviceBox1";
            this.serviceBox1.Size = new System.Drawing.Size(281, 264);
            this.serviceBox1.TabIndex = 2;
            this.serviceBox1.TabStop = false;
            this.serviceBox1.Visible = false;
            // 
            // costCurrentService1
            // 
            this.costCurrentService1.Location = new System.Drawing.Point(195, 151);
            this.costCurrentService1.Name = "costCurrentService1";
            this.costCurrentService1.Size = new System.Drawing.Size(71, 20);
            this.costCurrentService1.TabIndex = 11;
            this.costCurrentService1.Visible = false;
            // 
            // deleteServicePicture1
            // 
            this.deleteServicePicture1.BackgroundImage = global::DATAO.Properties.Resources.deleteservice;
            this.deleteServicePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteServicePicture1.InitialImage = null;
            this.deleteServicePicture1.Location = new System.Drawing.Point(236, 23);
            this.deleteServicePicture1.Name = "deleteServicePicture1";
            this.deleteServicePicture1.Size = new System.Drawing.Size(30, 29);
            this.deleteServicePicture1.TabIndex = 4;
            this.deleteServicePicture1.TabStop = false;
            this.deleteServicePicture1.Click += new System.EventHandler(this.deleteServicePicture1_Click);
            // 
            // changePicture1
            // 
            this.changePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePicture1.Image = global::DATAO.Properties.Resources.changeservice;
            this.changePicture1.Location = new System.Drawing.Point(18, 19);
            this.changePicture1.Name = "changePicture1";
            this.changePicture1.Size = new System.Drawing.Size(40, 40);
            this.changePicture1.TabIndex = 3;
            this.changePicture1.TabStop = false;
            this.changePicture1.Click += new System.EventHandler(this.changePicture1_Click);
            // 
            // timeService1
            // 
            this.timeService1.AutoSize = true;
            this.timeService1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeService1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeService1.Location = new System.Drawing.Point(14, 202);
            this.timeService1.Name = "timeService1";
            this.timeService1.Size = new System.Drawing.Size(140, 24);
            this.timeService1.TabIndex = 2;
            this.timeService1.Text = "Длительность";
            // 
            // costService1
            // 
            this.costService1.AutoSize = true;
            this.costService1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costService1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.costService1.Location = new System.Drawing.Point(8, 139);
            this.costService1.Name = "costService1";
            this.costService1.Size = new System.Drawing.Size(180, 38);
            this.costService1.TabIndex = 1;
            this.costService1.Text = "Стоимость";
            // 
            // nameServiceLabel1
            // 
            this.nameServiceLabel1.AutoEllipsis = true;
            this.nameServiceLabel1.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameServiceLabel1.ForeColor = System.Drawing.Color.Orange;
            this.nameServiceLabel1.Location = new System.Drawing.Point(6, 73);
            this.nameServiceLabel1.Name = "nameServiceLabel1";
            this.nameServiceLabel1.Size = new System.Drawing.Size(269, 42);
            this.nameServiceLabel1.TabIndex = 0;
            this.nameServiceLabel1.Text = "Название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statService);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serviceEndDate);
            this.groupBox1.Controls.Add(this.serviceStartDate);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(56, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // statService
            // 
            this.statService.AutoSize = true;
            this.statService.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statService.Location = new System.Drawing.Point(14, 80);
            this.statService.Name = "statService";
            this.statService.Size = new System.Drawing.Size(504, 33);
            this.statService.TabIndex = 6;
            this.statService.Text = "Выполнено(раз) : --- на сумму(руб) : ------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "с:";
            // 
            // serviceEndDate
            // 
            this.serviceEndDate.Location = new System.Drawing.Point(362, 33);
            this.serviceEndDate.Name = "serviceEndDate";
            this.serviceEndDate.Size = new System.Drawing.Size(142, 20);
            this.serviceEndDate.TabIndex = 3;
            this.serviceEndDate.ValueChanged += new System.EventHandler(this.serviceEndDate_ValueChanged);
            // 
            // serviceStartDate
            // 
            this.serviceStartDate.Location = new System.Drawing.Point(201, 34);
            this.serviceStartDate.Name = "serviceStartDate";
            this.serviceStartDate.Size = new System.Drawing.Size(141, 20);
            this.serviceStartDate.TabIndex = 2;
            this.serviceStartDate.ValueChanged += new System.EventHandler(this.serviceStartDate_ValueChanged);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(25, 33);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(156, 21);
            this.serviceComboBox.TabIndex = 1;
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Услуга:";
            // 
            // serviceBox
            // 
            this.serviceBox.Controls.Add(this.costCurrentService);
            this.serviceBox.Controls.Add(this.deleteServicePicture);
            this.serviceBox.Controls.Add(this.changePicture);
            this.serviceBox.Controls.Add(this.timeService);
            this.serviceBox.Controls.Add(this.costService);
            this.serviceBox.Controls.Add(this.nameServiceLabel);
            this.serviceBox.Location = new System.Drawing.Point(49, 61);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(281, 264);
            this.serviceBox.TabIndex = 0;
            this.serviceBox.TabStop = false;
            this.serviceBox.Visible = false;
            // 
            // costCurrentService
            // 
            this.costCurrentService.Location = new System.Drawing.Point(195, 151);
            this.costCurrentService.Name = "costCurrentService";
            this.costCurrentService.Size = new System.Drawing.Size(71, 20);
            this.costCurrentService.TabIndex = 5;
            this.costCurrentService.Visible = false;
            // 
            // deleteServicePicture
            // 
            this.deleteServicePicture.BackgroundImage = global::DATAO.Properties.Resources.deleteservice;
            this.deleteServicePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteServicePicture.InitialImage = null;
            this.deleteServicePicture.Location = new System.Drawing.Point(236, 23);
            this.deleteServicePicture.Name = "deleteServicePicture";
            this.deleteServicePicture.Size = new System.Drawing.Size(30, 29);
            this.deleteServicePicture.TabIndex = 4;
            this.deleteServicePicture.TabStop = false;
            this.deleteServicePicture.Click += new System.EventHandler(this.deleteServicePicture_Click);
            // 
            // changePicture
            // 
            this.changePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePicture.Image = global::DATAO.Properties.Resources.changeservice;
            this.changePicture.Location = new System.Drawing.Point(18, 19);
            this.changePicture.Name = "changePicture";
            this.changePicture.Size = new System.Drawing.Size(40, 40);
            this.changePicture.TabIndex = 3;
            this.changePicture.TabStop = false;
            this.changePicture.Click += new System.EventHandler(this.changePicture_Click);
            // 
            // timeService
            // 
            this.timeService.AutoSize = true;
            this.timeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeService.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeService.Location = new System.Drawing.Point(14, 202);
            this.timeService.Name = "timeService";
            this.timeService.Size = new System.Drawing.Size(140, 24);
            this.timeService.TabIndex = 2;
            this.timeService.Text = "Длительность";
            // 
            // costService
            // 
            this.costService.AutoSize = true;
            this.costService.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costService.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.costService.Location = new System.Drawing.Point(8, 139);
            this.costService.Name = "costService";
            this.costService.Size = new System.Drawing.Size(180, 38);
            this.costService.TabIndex = 1;
            this.costService.Text = "Стоимость";
            // 
            // nameServiceLabel
            // 
            this.nameServiceLabel.AutoEllipsis = true;
            this.nameServiceLabel.Font = new System.Drawing.Font("Roboto Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameServiceLabel.ForeColor = System.Drawing.Color.Orange;
            this.nameServiceLabel.Location = new System.Drawing.Point(6, 73);
            this.nameServiceLabel.Name = "nameServiceLabel";
            this.nameServiceLabel.Size = new System.Drawing.Size(260, 42);
            this.nameServiceLabel.TabIndex = 0;
            this.nameServiceLabel.Text = "Название";
            // 
            // Sklad
            // 
            this.Sklad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Sklad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sklad.Controls.Add(this.completeIncomeButton);
            this.Sklad.Controls.Add(this.syncSkladButton);
            this.Sklad.Controls.Add(this.skladGrid);
            this.Sklad.Controls.Add(this.searchValueSkladtextBox);
            this.Sklad.Controls.Add(this.statisticsSkladBox);
            this.Sklad.Controls.Add(this.searchSkladBox);
            this.Sklad.Controls.Add(this.deleteFromSkladPictureBox);
            this.Sklad.Controls.Add(this.addToSkladPictureBox);
            this.Sklad.Location = new System.Drawing.Point(4, 22);
            this.Sklad.Name = "Sklad";
            this.Sklad.Size = new System.Drawing.Size(1273, 574);
            this.Sklad.TabIndex = 3;
            this.Sklad.Text = "Склад";
            // 
            // completeIncomeButton
            // 
            this.completeIncomeButton.Depth = 0;
            this.completeIncomeButton.Location = new System.Drawing.Point(365, 213);
            this.completeIncomeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.completeIncomeButton.Name = "completeIncomeButton";
            this.completeIncomeButton.Primary = true;
            this.completeIncomeButton.Size = new System.Drawing.Size(56, 37);
            this.completeIncomeButton.TabIndex = 12;
            this.completeIncomeButton.Text = "ОК";
            this.completeIncomeButton.UseVisualStyleBackColor = true;
            this.completeIncomeButton.Visible = false;
            this.completeIncomeButton.Click += new System.EventHandler(this.completeIncomeButton_Click);
            // 
            // syncSkladButton
            // 
            this.syncSkladButton.Depth = 0;
            this.syncSkladButton.Location = new System.Drawing.Point(365, 152);
            this.syncSkladButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.syncSkladButton.Name = "syncSkladButton";
            this.syncSkladButton.Primary = true;
            this.syncSkladButton.Size = new System.Drawing.Size(56, 45);
            this.syncSkladButton.TabIndex = 11;
            this.syncSkladButton.Text = "Синхр.";
            this.syncSkladButton.UseVisualStyleBackColor = true;
            this.syncSkladButton.Click += new System.EventHandler(this.syncSkladButton_Click);
            // 
            // skladGrid
            // 
            this.skladGrid.AutoSize = true;
            this.skladGrid.AutoStretchColumnsToFitWidth = true;
            this.skladGrid.EnableSort = true;
            this.skladGrid.Location = new System.Drawing.Point(427, 33);
            this.skladGrid.Name = "skladGrid";
            this.skladGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.skladGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.skladGrid.Size = new System.Drawing.Size(793, 514);
            this.skladGrid.SpecialKeys = SourceGrid.GridSpecialKeys.Shift;
            this.skladGrid.TabIndex = 8;
            this.skladGrid.TabStop = true;
            this.skladGrid.ToolTipText = "";
            // 
            // searchValueSkladtextBox
            // 
            this.searchValueSkladtextBox.Location = new System.Drawing.Point(58, 135);
            this.searchValueSkladtextBox.Name = "searchValueSkladtextBox";
            this.searchValueSkladtextBox.Size = new System.Drawing.Size(230, 20);
            this.searchValueSkladtextBox.TabIndex = 6;
            // 
            // statisticsSkladBox
            // 
            this.statisticsSkladBox.Controls.Add(this.confirmIncomeRaisedButton1);
            this.statisticsSkladBox.Controls.Add(this.dateIncome);
            this.statisticsSkladBox.Controls.Add(this.label4);
            this.statisticsSkladBox.Controls.Add(this.label3);
            this.statisticsSkladBox.Controls.Add(this.costIncometextBox4);
            this.statisticsSkladBox.Controls.Add(this.providerIncometextBox);
            this.statisticsSkladBox.Controls.Add(this.label1);
            this.statisticsSkladBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statisticsSkladBox.Location = new System.Drawing.Point(35, 252);
            this.statisticsSkladBox.Name = "statisticsSkladBox";
            this.statisticsSkladBox.Size = new System.Drawing.Size(278, 295);
            this.statisticsSkladBox.TabIndex = 4;
            this.statisticsSkladBox.TabStop = false;
            this.statisticsSkladBox.Text = "Прием товара";
            // 
            // confirmIncomeRaisedButton1
            // 
            this.confirmIncomeRaisedButton1.Depth = 0;
            this.confirmIncomeRaisedButton1.Location = new System.Drawing.Point(73, 235);
            this.confirmIncomeRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmIncomeRaisedButton1.Name = "confirmIncomeRaisedButton1";
            this.confirmIncomeRaisedButton1.Primary = true;
            this.confirmIncomeRaisedButton1.Size = new System.Drawing.Size(133, 38);
            this.confirmIncomeRaisedButton1.TabIndex = 11;
            this.confirmIncomeRaisedButton1.Text = "Принять";
            this.confirmIncomeRaisedButton1.UseVisualStyleBackColor = true;
            this.confirmIncomeRaisedButton1.Click += new System.EventHandler(this.confirmIncomeRaisedButton1_Click);
            // 
            // dateIncome
            // 
            this.dateIncome.Location = new System.Drawing.Point(26, 65);
            this.dateIncome.Name = "dateIncome";
            this.dateIncome.Size = new System.Drawing.Size(200, 20);
            this.dateIncome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стоимость всего заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поставщик";
            // 
            // costIncometextBox4
            // 
            this.costIncometextBox4.Location = new System.Drawing.Point(23, 192);
            this.costIncometextBox4.Name = "costIncometextBox4";
            this.costIncometextBox4.Size = new System.Drawing.Size(230, 20);
            this.costIncometextBox4.TabIndex = 7;
            // 
            // providerIncometextBox
            // 
            this.providerIncometextBox.Location = new System.Drawing.Point(23, 127);
            this.providerIncometextBox.Name = "providerIncometextBox";
            this.providerIncometextBox.Size = new System.Drawing.Size(230, 20);
            this.providerIncometextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата";
            // 
            // searchSkladBox
            // 
            this.searchSkladBox.Controls.Add(this.searchSkladShowButton);
            this.searchSkladBox.Controls.Add(this.label6);
            this.searchSkladBox.Controls.Add(this.searchComboBox);
            this.searchSkladBox.Controls.Add(this.label5);
            this.searchSkladBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchSkladBox.Location = new System.Drawing.Point(35, 25);
            this.searchSkladBox.Name = "searchSkladBox";
            this.searchSkladBox.Size = new System.Drawing.Size(278, 190);
            this.searchSkladBox.TabIndex = 7;
            this.searchSkladBox.TabStop = false;
            this.searchSkladBox.Text = "Поиск";
            // 
            // searchSkladShowButton
            // 
            this.searchSkladShowButton.Depth = 0;
            this.searchSkladShowButton.Location = new System.Drawing.Point(86, 149);
            this.searchSkladShowButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchSkladShowButton.Name = "searchSkladShowButton";
            this.searchSkladShowButton.Primary = true;
            this.searchSkladShowButton.Size = new System.Drawing.Size(97, 23);
            this.searchSkladShowButton.TabIndex = 6;
            this.searchSkladShowButton.Text = "Показать";
            this.searchSkladShowButton.UseVisualStyleBackColor = true;
            this.searchSkladShowButton.Click += new System.EventHandler(this.searchSkladShowButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Критерий";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Артикул",
            "Наименование",
            "Поставщик",
            "Стоимость",
            "Остаток"});
            this.searchComboBox.Location = new System.Drawing.Point(23, 61);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(230, 21);
            this.searchComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Значение";
            // 
            // deleteFromSkladPictureBox
            // 
            this.deleteFromSkladPictureBox.BackgroundImage = global::DATAO.Properties.Resources._;
            this.deleteFromSkladPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteFromSkladPictureBox.Location = new System.Drawing.Point(365, 90);
            this.deleteFromSkladPictureBox.Name = "deleteFromSkladPictureBox";
            this.deleteFromSkladPictureBox.Size = new System.Drawing.Size(56, 45);
            this.deleteFromSkladPictureBox.TabIndex = 10;
            this.deleteFromSkladPictureBox.TabStop = false;
            this.deleteFromSkladPictureBox.Click += new System.EventHandler(this.deleteFromSkladPictureBox_Click);
            // 
            // addToSkladPictureBox
            // 
            this.addToSkladPictureBox.BackgroundImage = global::DATAO.Properties.Resources.__;
            this.addToSkladPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addToSkladPictureBox.Location = new System.Drawing.Point(365, 35);
            this.addToSkladPictureBox.Name = "addToSkladPictureBox";
            this.addToSkladPictureBox.Size = new System.Drawing.Size(56, 48);
            this.addToSkladPictureBox.TabIndex = 9;
            this.addToSkladPictureBox.TabStop = false;
            this.addToSkladPictureBox.Click += new System.EventHandler(this.addToSkladPictureBox_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1281, 62);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // settingButton
            // 
            this.settingButton.Depth = 0;
            this.settingButton.Location = new System.Drawing.Point(1160, 34);
            this.settingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingButton.Name = "settingButton";
            this.settingButton.Primary = true;
            this.settingButton.Size = new System.Drawing.Size(108, 39);
            this.settingButton.TabIndex = 5;
            this.settingButton.Text = "Настройки";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // reportRaisedButton1
            // 
            this.reportRaisedButton1.Depth = 0;
            this.reportRaisedButton1.Location = new System.Drawing.Point(1043, 34);
            this.reportRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportRaisedButton1.Name = "reportRaisedButton1";
            this.reportRaisedButton1.Primary = true;
            this.reportRaisedButton1.Size = new System.Drawing.Size(111, 39);
            this.reportRaisedButton1.TabIndex = 6;
            this.reportRaisedButton1.Text = "Отчет";
            this.reportRaisedButton1.UseVisualStyleBackColor = true;
            this.reportRaisedButton1.Click += new System.EventHandler(this.reportRaisedButton1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.reportRaisedButton1);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "\"Название салона\"";
            this.Load += new System.EventHandler(this.AdminForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            this.Calendar.PerformLayout();
            this.Personal.ResumeLayout(false);
            this.Personal.PerformLayout();
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Uslugi.ResumeLayout(false);
            this.Uslugi.PerformLayout();
            this.newServiceBox.ResumeLayout(false);
            this.newServiceBox.PerformLayout();
            this.serviceBox3.ResumeLayout(false);
            this.serviceBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture3)).EndInit();
            this.serviceBox2.ResumeLayout(false);
            this.serviceBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture2)).EndInit();
            this.serviceBox1.ResumeLayout(false);
            this.serviceBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serviceBox.ResumeLayout(false);
            this.serviceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteServicePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePicture)).EndInit();
            this.Sklad.ResumeLayout(false);
            this.Sklad.PerformLayout();
            this.statisticsSkladBox.ResumeLayout(false);
            this.statisticsSkladBox.PerformLayout();
            this.searchSkladBox.ResumeLayout(false);
            this.searchSkladBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromSkladPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToSkladPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Uslugi;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private MaterialSkin.Controls.MaterialRaisedButton AddEventButton;
        private MaterialSkin.Controls.MaterialRaisedButton checkEventButton;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage Sklad;
        private System.Windows.Forms.ListBox personalListBox;
        private MaterialSkin.Controls.MaterialRaisedButton newPersonalButton;
        private System.Windows.Forms.GroupBox statisticsSkladBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costIncometextBox4;
        private System.Windows.Forms.TextBox providerIncometextBox;
        private System.Windows.Forms.TextBox searchValueSkladtextBox;
        private System.Windows.Forms.GroupBox searchSkladBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phonePersonalTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private MaterialSkin.Controls.MaterialCheckBox editPersonalCheckBox;
        private SourceGrid.Grid skladGrid;
        private System.Windows.Forms.PictureBox addToSkladPictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton settingButton;
        private System.Windows.Forms.PictureBox deleteFromSkladPictureBox;
        private SourceGrid.Grid ScheduleGrid;
        private MaterialSkin.Controls.MaterialRaisedButton deleteEventButton;
        private System.Windows.Forms.GroupBox serviceBox;
        private System.Windows.Forms.Label nameServiceLabel;
        private System.Windows.Forms.Label costService;
        private System.Windows.Forms.Label timeService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox changePicture;
        private System.Windows.Forms.PictureBox deleteServicePicture;
        private System.Windows.Forms.GroupBox serviceBox3;
        private System.Windows.Forms.PictureBox deleteServicePicture3;
        private System.Windows.Forms.PictureBox changePicture3;
        private System.Windows.Forms.Label timeService3;
        private System.Windows.Forms.Label costService3;
        private System.Windows.Forms.Label nameServiceLabel3;
        private System.Windows.Forms.GroupBox serviceBox2;
        private System.Windows.Forms.PictureBox deleteServicePicture2;
        private System.Windows.Forms.PictureBox changePicture2;
        private System.Windows.Forms.Label timeService2;
        private System.Windows.Forms.Label costService2;
        private System.Windows.Forms.Label nameServiceLabel2;
        private System.Windows.Forms.GroupBox serviceBox1;
        private System.Windows.Forms.PictureBox deleteServicePicture1;
        private System.Windows.Forms.PictureBox changePicture1;
        private System.Windows.Forms.Label timeService1;
        private System.Windows.Forms.Label costService1;
        private System.Windows.Forms.Label nameServiceLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton rightButton;
        private MaterialSkin.Controls.MaterialRaisedButton leftButton;
        private System.Windows.Forms.Label numberPageLabel;
        private MaterialSkin.Controls.MaterialRaisedButton saveServiceButton;
        private MaterialSkin.Controls.MaterialRaisedButton newServiceButton;
        private System.Windows.Forms.GroupBox newServiceBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newCostServiceTextBox;
        private System.Windows.Forms.TextBox newNameServiceTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton saveChangePersonalButton;
        private MaterialSkin.Controls.MaterialRaisedButton searchSkladShowButton;
        private MaterialSkin.Controls.MaterialRaisedButton syncSkladButton;
        private System.Windows.Forms.MaskedTextBox endPersonalDay;
        private System.Windows.Forms.MaskedTextBox startPersonalDay;
        private System.Windows.Forms.MonthCalendar monthCalendarPersonal;
        private System.Windows.Forms.ComboBox newTimeServiceComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton reportRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton checkConfirmButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox costEventTextBox;
        private System.Windows.Forms.DateTimePicker dateIncome;
        private MaterialSkin.Controls.MaterialRaisedButton confirmIncomeRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton completeIncomeButton;
        private System.Windows.Forms.Label phonePeronalLabel;
        private System.Windows.Forms.Label namePeronalLabel;
        private System.Windows.Forms.Label ratePeronalLabel;
        private System.Windows.Forms.Label statusPeronalLabel;
        private System.Windows.Forms.Label addressPeronalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label endPersonalDayView;
        private System.Windows.Forms.Label startPersonalDayView;
        private System.Windows.Forms.Label statService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker serviceEndDate;
        private System.Windows.Forms.DateTimePicker serviceStartDate;
        private System.Windows.Forms.TextBox costCurrentService3;
        private System.Windows.Forms.TextBox costCurrentService2;
        private System.Windows.Forms.TextBox costCurrentService1;
        private System.Windows.Forms.TextBox costCurrentService;
    }
}