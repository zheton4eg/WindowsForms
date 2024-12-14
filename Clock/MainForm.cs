using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt",System.Globalization.CultureInfo.InvariantCulture);
            if(CBShowDate.Checked)
            {
                labelTime.Text += "\n"; 
                labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd"); 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            CBShowDate.Visible = false;
            btnHideControls.Visible = false;
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle=FormBorderStyle.None;
            labelTime.BackColor = Color.AliceBlue;
            this.ShowInTaskbar = false;
        }

        private void labelTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show
                            (
                this,
                "Вы два раза целкнули мышью по времени, и теперь вы управляете временем"
                , "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
