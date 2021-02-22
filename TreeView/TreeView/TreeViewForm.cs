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
using TreeView.Entities;
using TreeView.Helpers;
using TreeView.Models;

namespace TreeView
{
    public partial class TreeViewForm : Form
    {
        private readonly EFContext _context;
        public TreeViewForm()
        {
            InitializeComponent();
            _context = new EFContext();
            Seeder.SeedDatabase(_context);
            LoadFormData();
        }
        private void LoadFormData()
        {
            #region Begin work Breed

            var categories = _context.Breeds.Select(ic => new BreedGroupVM
            {
                Id = ic.Id,
                Name = ic.Name,
                UrlSlug = ic.UrlSlug,
                ParentId = ic.ParentId
            }).ToList();
            
            // Зробити дерево
            var tree = categories.BuildTree(); 

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = _context.Breeds
                .Where(x => x.ParentId == null)
                .Select(x => new BreedVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    UrlSlug = x.UrlSlug
                }).ToList();
            foreach (var item in list)
            {
                AddParent(item);
            }
            tvBreed.Focus();
        }
        private void AddParentNode(EFContext context, string urlSlug, string name)
        {
            context.Breeds.Add(new Breed
            {
                Name = name,
                ParentId = null,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }

        ///private static void AddChildToParent(EFContext context, string parentSlug, string urlSlug, string name)
        ///{
        ///    var parent = context.Breeds.SingleOrDefault(x => x.UrlSlug == parentSlug);
        ///    context.Breeds.Add(new Breed
        ///    {
        ///        Name = name,
        ///        ParentId = parent.Id,
        ///        UrlSlug = urlSlug
        ///    });
        ///    context.SaveChanges();
        ///}
        private void AddParent(BreedVM breed)
        {
            TreeNode node = new TreeNode();
            node.Text = breed.Name;
            node.Name = breed.Id.ToString();
            node.Tag = breed;
            node.Nodes.Add("");
            tvBreed.Nodes.Add(node);

        }
        private void AddChild(TreeNode parent, BreedVM breed)
        {
            TreeNode node = new TreeNode();
            node.Text = breed.Name;
            node.Name = breed.Id.ToString();
            node.Tag = breed;
            node.Nodes.Add("");
            parent.Nodes.Add(node);
        }
        private void btnAddParent_Click(object sender, EventArgs e)
        {
            string name = tbAddParent.Text;
            string urlSlug = tbUrlSlug.Text;
            //TreeNode newNode = new TreeNode(name);
            //tvBreed.Nodes.Add(newNode);
            if (name == "")
            {
                MessageBox.Show("Заповніть поле НАЗВА!");
            }
            else
            {
                AddParentNode(_context, urlSlug, name);
            }
            tbAddParent.Clear();
            tbUrlSlug.Clear();
        }
        private void btnAddElement_Click(object sender, EventArgs e)
        {
            string name = tbAddElement.Text;
            TreeNode newNode = new TreeNode(name);
            tvBreed.SelectedNode.Nodes.Add(newNode);
            tbAddElement.Clear();
        }
        private void tvBreed_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                var parent = e.Node;
                var parentId = (parent.Tag as BreedVM).Id;
                parent.Nodes.Clear();
                var list = _context.Breeds
                .Where(x => x.ParentId == parentId)
                .Select(x => new BreedVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                    UrlSlug = x.UrlSlug
                }).ToList();

                foreach (var item in list)
                {
                    AddChild(parent, item);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tvBreed.Nodes.Remove(tvBreed.SelectedNode);
        }
    }
}
