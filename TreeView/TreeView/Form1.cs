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
    public partial class Form1 : Form
    {
        private readonly EFContext _context;
        public Form1()
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
                //MessageBox.Show(parentId.ToString());
            }
        }
    }
}
