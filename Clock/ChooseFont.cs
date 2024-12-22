using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clock
{
    public partial class nudFontSize : Form
    {

        public nudFontSize()
        {
            InitializeComponent();
            LoadFonts();
        }
       void LoadFonts()
        {
            Directory.SetCurrentDirectory("..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());

              
            cbFonts.Items.AddRange(GetFontsFormat("*.ttf"));
            cbFonts.Items.AddRange(GetFontsFormat("*.otf"));
        }
        static string[] GetFontsFormat(string format)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Fonts", format);
            for (int i = 0; i < files.Length; i++)
                files[i] = files[i].Split('\\').Last();
            return files;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
