using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Window
{
    public partial class Fri : Form
    {
        public static string fir ;
        public Fri()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            fir = (string)listBox1.SelectedItem;
            chat c = new chat();
            Hide();
            c.Show();
        }
    }
}
