using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // событие перед раскрытием узла
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }
        // событие перед выделением узла
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        
    }
}
