using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace lion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void searchGoogle(string Query)
        {
            Process.Start("https://duckduckgo.com/?hps=1&q=" + Query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchGoogle(textBox1.Text);

        }
    }
}
