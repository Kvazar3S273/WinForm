using Rozetka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Rozetka.Entities;

namespace Rozetka
{
    public partial class AddValueForm : Form
    {
        private readonly EFContext context = new EFContext();
        public AddValueForm()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            // Отримуємо назви фільтрів в комбобокс
            var queryName = from f in context.FilterNames.AsQueryable() select f.Name;
            foreach (var item in queryName)
            {
                cbFilter.Items.Add(item);
            }
        }

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            context.FilterValues.Add(
                new FilterValue
                {
                    Name = tbValue.Text
                });
            context.SaveChanges();
            var nameId = context.FilterNames
                .SingleOrDefault(fn => fn.Name == cbFilter.SelectedItem.ToString()).Id;
            var valueId = context.FilterValues
                .SingleOrDefault(fv => fv.Name == tbValue.Text).Id;
            // Зв'язуємо в групу назву фільтра і додане значення
            if(context.FilterNameGroups
                .SingleOrDefault(fng=>fng.FilterValueId==valueId 
                && fng.FilterNameId==nameId)==null)
            {
                context.FilterNameGroups.Add(
                    new FilterNameGroup
                    {
                        FilterNameId = nameId,
                        FilterValueId = valueId
                    });
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
