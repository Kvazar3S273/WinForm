using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStatic_MouseMove(object sender, MouseEventArgs e)
        {
            btnStatic.Location = new Point(rnd.Next(this.Width - (btnStatic.Width*2)), 
                rnd.Next(this.Height - (btnStatic.Height*2)));
        }
    }
}
