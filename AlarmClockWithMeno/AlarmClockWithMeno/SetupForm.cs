using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockWithMeno
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }
        private void SetupForm_Load(object sender, EventArgs e)
        {
            MinUpDown.Value = Convert.ToInt32(DateTime.Now.Minute);
            HrUpDown.Value = Convert.ToInt32(DateTime.Now.Hour);
            DayUpDown.Value = Convert.ToInt32(DateTime.Now.Day);
            MonUpDown.Value = Convert.ToInt32(DateTime.Now.Month);
            YearUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (((MainForm)this.Owner).managerOfEvent.count > 9)
            {
                DialogResult result1 = MessageBox.Show("You have created a more than 10 alarms. If the amount in box ''Active reminders'' < 10, some events may have expired.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (result1 == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                int Iyear, Imonth, Idate, Ihour, Iminute;
                Iyear = Convert.ToInt32(YearUpDown.Value);
                Imonth = Convert.ToInt32(MonUpDown.Value);
                Idate = Convert.ToInt32(DayUpDown.Value);
                Ihour = Convert.ToInt32(HrUpDown.Value);
                Iminute = Convert.ToInt32(MinUpDown.Value);

                DateTime date1 = new DateTime(Iyear, Imonth, Idate, Ihour, Iminute, 0);
                for (int i = 0; i < ((MainForm)this.Owner).managerOfEvent.count; i++)
                {
                    if (date1 == ((MainForm)this.Owner).managerOfEvent.Events[i].GetDateAndTime())
                    {
                        DialogResult result2 = MessageBox.Show("This event currently has registered.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                            return;
                        }
                    }
                }
                if (DateTime.Compare(date1, DateTime.Now) < 0)
                {
                    DialogResult result2 = MessageBox.Show("This reminder is in the past, this event will not be added", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (result2 == DialogResult.OK)
                    {
                        this.Close();
                        return;
                    }
                }
                // Adding new event
                ((MainForm)this.Owner).managerOfEvent.Events[((MainForm)this.Owner).managerOfEvent.count++] = new MainForm.MyEvent(date1, this.textBox1.Text);

                // Sorting events
                ((MainForm)this.Owner).managerOfEvent.sort();

                MessageBox.Show("Reminder successfully saved", "AddEvent", MessageBoxButtons.OK, MessageBoxIcon.Information); //message when you click "save"
                this.Close(); //closed shape

            }
        }
    }
}
