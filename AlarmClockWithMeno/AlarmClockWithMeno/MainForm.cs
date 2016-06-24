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
        public MainForm()
        {
            InitializeComponent();
        }

        private void etimer_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupForm setform = new SetupForm();
            setform.ShowInTaskbar = false;
            setform.StartPosition = FormStartPosition.CenterScreen;
            setform.ShowDialog(this);
        }
    }
}
