using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Organization;

namespace DATAO
{
    public partial class EventForm : MaterialForm
    {
        DateTime data;
        TimeSpan startTime;
        TimeSpan endTime;
        string nameWorker;
        AdminForm ad;
        public EventForm(AdminForm adF, DateTime data1, TimeSpan startTime1, TimeSpan endTime1, string nameWorker1)
        {
            InitializeComponent();
            ad = adF;
            data = data1;
            startTime = startTime1;
            endTime = endTime1;
            nameWorker = nameWorker1;
            selectWorker.Text = nameWorker1;
            selectTimeStart.Text = startTime1.ToString();
            selectTimeEnd.Text = endTime1.ToString();
            foreach (Service s in Enterprise.PriceList)
            {
                if ((endTime1 - startTime1) >= s.Duration)
                {
                    selectService.Items.Add(s.About.Name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(data.ToString()+" "+startTime.ToString()+" "+endTime.ToString()+" "+nameWorker);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (data != null && startTime != null && endTime != null && nameWorker != null && clientName.Text != "")
            {
                Event currentEvent = new Event(Enterprise.PriceList.Find(pl => pl.About.Name == selectService.SelectedItem.ToString()));
                currentEvent.RecordDate = data + startTime;
                currentEvent.Master = Enterprise.Personal.Find(w => w.About.Name == nameWorker);
                Client customer = new Client();
                customer.About.Name = clientName.Text;
                currentEvent.Customer = customer;
                Enterprise.Personal.Find(w => w.About.Name == nameWorker).Events.Add(currentEvent);
                customer.Events.Add(currentEvent);
                ad.UpdateSchedule();
                Hide();
            }
        }

        private void selectService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
