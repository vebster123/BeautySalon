using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Organization;
using ExcelManager;

namespace DATAO
{
    public partial class SetForm : MaterialForm
    {
        AdminForm adF;
        public SetForm(AdminForm af)
        {
            InitializeComponent();
            loadrasp();
            this.adF = af;
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            nameOrgTextBox.Text = Enterprise.About.Name;
            phoneTextBox.Text = Enterprise.About.Fields["Телефон"];
            actualAddressTextBox.Text = Enterprise.About.Fields["Фактический адрес"];
            legfalAddressTextBox.Text = Enterprise.About.Fields["Юридический адрес"];
            tinTextBox.Text = Enterprise.About.Fields["ИНН"];
            accountNumberTextBox.Mask = "00000000000000000000";
            accountNumberTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(accountNumberTextBox_MaskInputRejected);
            accountNumberTextBox.Text = Enterprise.About.Fields["Расчетный счет"];
        }
        private void accountNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Неправильный ввод";
            toolTip1.Show("Номер счета должен состоять из 20 цифр", accountNumberTextBox, this.accountNumberTextBox.Location, 5000);
        }
        private void loadrasp()
        {
            scheduleGrid.BorderStyle = BorderStyle.FixedSingle;
            scheduleGrid.ColumnsCount = 7;
            scheduleGrid.FixedRows = 1;
            scheduleGrid.Rows.Insert(0);
            //Массив
            scheduleGrid[0, 0] = new SourceGrid.Cells.ColumnHeader("Понедельник");
            scheduleGrid[0, 1] = new SourceGrid.Cells.ColumnHeader("Вторник");
            scheduleGrid[0, 2] = new SourceGrid.Cells.ColumnHeader("Среда");
            scheduleGrid[0, 3] = new SourceGrid.Cells.ColumnHeader("Четверг");
            scheduleGrid[0, 4] = new SourceGrid.Cells.ColumnHeader("Пятница");
            scheduleGrid[0, 5] = new SourceGrid.Cells.ColumnHeader("Суббота");
            scheduleGrid[0, 6] = new SourceGrid.Cells.ColumnHeader("Воскресенье");
            try
            {
                scheduleGrid.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[1, i] = new SourceGrid.Cells.Cell(Enterprise.TimeTable[(Days)i+1][0], typeof(TimeSpan)); }

                scheduleGrid.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[2, i] = new SourceGrid.Cells.Cell(Enterprise.TimeTable[(Days)i+1][1], typeof(TimeSpan)); }
            }
            catch (ArgumentOutOfRangeException)
            {
                scheduleGrid.Rows.Insert(1);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[1, i] = new SourceGrid.Cells.Cell(string.Empty, typeof(TimeSpan)); }
                

                scheduleGrid.Rows.Insert(2);
                for (int i = 0; i < 7; i++)
                { scheduleGrid[2, i] = new SourceGrid.Cells.Cell(string.Empty, typeof(TimeSpan)); }
            }
            scheduleGrid.AutoSizeCells();
        }

        private void confirmlFlatButton_Click(object sender, EventArgs e)
        {
            Enterprise.About.Name = nameOrgTextBox.Text;
            Enterprise.About.Fields["Телефон"] = phoneTextBox.Text;
            Enterprise.About.Fields["Фактический адрес"] = actualAddressTextBox.Text;
            Enterprise.About.Fields["Юридический адрес"] = legfalAddressTextBox.Text;
            Enterprise.About.Fields["ИНН"] = tinTextBox.Text;
            Enterprise.About.Fields["Расчетный счет"] = accountNumberTextBox.Text;
            for (int i = 0; i < 7; i++)
                {
                    Enterprise.TimeTable[(Days)i + 1][0] = DateTime.Parse(scheduleGrid[1, i].Value.ToString()).TimeOfDay;
                    Enterprise.TimeTable[(Days)i + 1][1] = DateTime.Parse(scheduleGrid[2, i].Value.ToString()).TimeOfDay;
            }
            adF.Name = nameOrgTextBox.Text;
            adF.UpdateSchedule();
            Close();
        }        
    }
}
