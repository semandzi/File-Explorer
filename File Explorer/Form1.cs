using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select you're path" }) {
                if (fbd.ShowDialog() == DialogResult.OK)
            
                    browser.Url=new Uri(fbd.SelectedPath);
                txtPath.Text = fbd.SelectedPath;

            }
        }


        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
                browser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
                browser.GoForward();
        }

        
    }
}
