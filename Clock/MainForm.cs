using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Clock
{
    public partial class MainForm : Form
    {
        // ChooseFontForm fontDialog = new ChooseFontForm();
        nudFontSize fontDialog = null;
        public MainForm()
        {
            InitializeComponent();
            labelTime.BackColor = Color.AliceBlue;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width-this.Width,50);
            SetVisibility(false);
            cmShowConsole.Checked = true;   
            fontDialog=new nudFontSize();
        }
        void SetVisibility(bool visible)
        {
            CBShowDate.Visible = visible;
            cbShowWeekDay.Visible = visible;
            btnHideControls.Visible = visible;
            this.TransparencyKey = visible?Color.Empty:this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow: FormBorderStyle.None;
            labelTime.BackColor = Color.AliceBlue;
           this.ShowInTaskbar = visible;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt",System.Globalization.CultureInfo.InvariantCulture);
            if(CBShowDate.Checked)
            {
                labelTime.Text += "\n"; 
                labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd"); 
            }
            if(cbShowWeekDay.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.DayOfWeek;
            }
            notifyIcon.Text = labelTime.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cmShowDate.Checked=CBShowDate.Checked;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //CBShowDate.Visible = false;
            //btnHideControls.Visible = false;
            //this.TransparencyKey = this.BackColor;
            //this.FormBorderStyle=FormBorderStyle.None;
            //labelTime.BackColor = Color.AliceBlue;
            //this.ShowInTaskbar = false;
             SetVisibility(cmShowControls.Checked = false);
           
        }

        private void labelTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show
            //                (
            //    this,
            //    "Вы два раза целкнули мышью по времени, и теперь вы управляете временем"
            //    , "Info",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //    );
            SetVisibility(cmShowControls.Checked = true); 

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            cmShowComsole.Checked=cbShowWeekDay.Checked;
        }

        private void cmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmTopmost_Click(object sender, EventArgs e)
        {

        }

        private void cmTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cmTopmost.Checked;
        }

        private void cmShowDate_CheckedChanged(object sender, EventArgs e)
        {
CBShowDate.Checked = cmShowDate.Checked;
        }

        private void cmShowWeekday_CheckedChanged(object sender, EventArgs e)
        {
            cbShowWeekDay.Checked = cmShowComsole.Checked;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SetColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            
            switch ((( ToolStripMenuItem)sender).Text)
            {
                case "Background color": dialog.Color = labelTime.BackColor; break;
                case "Foreground color": dialog.Color = labelTime.ForeColor; break;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch((sender as ToolStripMenuItem).Text)
                {
                    case "Background color":labelTime.BackColor=dialog.Color; break;    
                    case "Foreground color":labelTime.ForeColor=dialog.Color; break;    
                }
            }
        }

        private void cmShowControls_CheckedChanged(object sender, EventArgs e)
        {
SetVisibility(cmShowControls.Checked);
        }

        private void cmChooseFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }

        private void cmShowConsole_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
                AllocConsole();
            else
                FreeConsole();
        }  
            [DllImport("kernel32.dll")]
            public static extern bool AllocConsole();
            [DllImport("kernel32.dll")]
            public static extern bool FreeConsole();
        
    }
}
