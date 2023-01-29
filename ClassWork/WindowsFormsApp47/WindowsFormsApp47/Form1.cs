using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    public partial class Form1 : Form
    {
        Newspaper newspaper;
        public Form1()
        {
            InitializeComponent();
            newspaper = new Newspaper();
            newspaper.AddObserver(new FirstObserver());
            newspaper.AddObserver(new SecondObserver());
            newspaper.AddObserver(new ThridObserver(label1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newspaper.NewNews(richTextBox1.Text);
        }
    }
}
