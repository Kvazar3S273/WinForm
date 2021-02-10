using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRoles.Entities;

namespace UserRoles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EFContext context = new EFContext();
            Seeder.SeedDataBase(context);
        }

    }
}
