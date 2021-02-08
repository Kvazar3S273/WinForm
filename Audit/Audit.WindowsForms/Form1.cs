using Audit.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audit.WindowsForms
{
    public partial class Form1 : Form
    {
        private readonly MyContext _context;
        public Form1()
        {
            _context = new MyContext();
            Seeder.SeedAll(_context);
            InitializeComponent();
        }

        private void bntGo_Click(object sender, EventArgs e)
        {
           // new QuestionForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
