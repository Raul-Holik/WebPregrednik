using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_preglednik
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           bookmark.Items.Add(webBrowser1.Url.ToString());
        }

        private void bookmark_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(bookmark.SelectedItem.ToString());
        }
    }
}
