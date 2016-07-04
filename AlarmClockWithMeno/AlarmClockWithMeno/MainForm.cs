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
    public partial class MainForm : Form
    {
        public class MyEvent
        {
            private DateTime DateAndTime;
            private string Message;
            private bool Active;

            public MyEvent(DateTime DateAndTime, string Message)
            {
                this.DateAndTime = DateAndTime;
                this.Message = Message;
                this.Active = true;
            }

            public DateTime GetDateAndTime() { return this.DateAndTime; }
            public string GetMessage() { return this.Message; }
            public bool IsActive() { return this.Active; }

            public void SetDateAndTime(DateTime DateAndTime) { this.DateAndTime = DateAndTime; }
            public void SetMessage(string Message) { this.Message = Message; }
            public void SetActive(bool State) { this.Active = State; }
        }

        public class Manager
        {
            public System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            public MyEvent[] Events = new MyEvent[10];
            public short count = 0;

            public int getActiveCount()
            {
                int con = 0;
                for (int i = 0; i < count; i++)
                    if (Events[i].IsActive())
                        con = con + 1;
                return con;
            }
            public void playsound()
            {
                sp.SoundLocation = (System.IO.Directory.GetCurrentDirectory() + @"\alarm_clock.wav");
                sp.Play();
            }
            public void sort()
            {
                for (int j = 0; j < count; j++)
                    for (int i = 0; i < count - 1; i++)
                    {
                        if (Events[i].IsActive() == false || Events[i].GetDateAndTime() > Events[i + 1].GetDateAndTime())
                        {
                            if (Events[i + 1].IsActive())
                            {
                                MyEvent tmp = Events[i];
                                Events[i] = Events[i + 1];
                                Events[i + 1] = tmp;
                            }
                        }
                    }
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void etimer_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm:ss");

            for (int i = 0; i < managerOfEvent.count; i++)
            {
                if (managerOfEvent.Events[i].IsActive())
                {
                    TimeDataGV.Rows[i + 1].Cells[1].Style.BackColor = Color.White;
                    TimeDataGV.Rows[i + 1].Cells[2].Style.BackColor = Color.White;
                    TimeDataGV.Rows[i + 1].Cells[1].Value = Convert.ToString(managerOfEvent.Events[i].GetDateAndTime());
                    TimeDataGV.Rows[i + 1].Cells[2].Value = Convert.ToString(managerOfEvent.Events[i].GetMessage());
                }
                else
                {
                    TimeDataGV.Rows[i + 1].Cells[1].Style.BackColor = Color.DimGray;
                    TimeDataGV.Rows[i + 1].Cells[2].Style.BackColor = Color.DimGray;
                    TimeDataGV.Rows[i + 1].Cells[1].Value = Convert.ToString(managerOfEvent.Events[i].GetDateAndTime());
                    TimeDataGV.Rows[i + 1].Cells[2].Value = Convert.ToString(managerOfEvent.Events[i].GetMessage());
                }
            }

            if (this.managerOfEvent.count == 0) return;

            if (this.managerOfEvent.Events[0].GetDateAndTime().Hour == DateTime.Now.Hour && this.managerOfEvent.Events[0].GetDateAndTime().Minute == DateTime.Now.Minute
                && this.managerOfEvent.Events[0].GetDateAndTime().Date == DateTime.Now.Date && this.managerOfEvent.Events[0].IsActive())
            {
                this.managerOfEvent.Events[0].SetActive(false);
                this.managerOfEvent.playsound();
                DialogResult result = MessageBox.Show(this.managerOfEvent.Events[0].GetMessage(), "Event", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    managerOfEvent.sp.Stop();
                }
            }
            this.managerOfEvent.sort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
            TimeDataGV.RowCount = 11;
            TimeDataGV.ColumnCount = 3;
            for (int i = 1; i < 11; i++)
            {
                TimeDataGV.Rows[i].Cells[0].Value = Convert.ToString(i);
            }
            TimeDataGV.Rows[0].Cells[0].Value = "Items";
            TimeDataGV.Rows[0].Cells[1].Value = "             Time             ";
            TimeDataGV.Rows[0].Cells[2].Value = "      Message     ";
            TimeDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TimeDataGV.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupForm setform = new SetupForm();
            setform.ShowInTaskbar = false;
            setform.StartPosition = FormStartPosition.CenterScreen;
            setform.ShowDialog(this);
        }

        public Manager managerOfEvent = new Manager();
        private SoundUtl sndtl;
    }
}
