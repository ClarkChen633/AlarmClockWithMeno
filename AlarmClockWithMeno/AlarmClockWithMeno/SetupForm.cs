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
            MinUpDown.Value = Convert.ToInt32(DateTime.Now.Hour);
            HrUpDown.Value = Convert.ToInt32(DateTime.Now.Minute);
            MonUpDown.Value = Convert.ToInt32(DateTime.Now.Day);
            YearUpDown.Value = Convert.ToInt32(DateTime.Now.Month);
            YearUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
