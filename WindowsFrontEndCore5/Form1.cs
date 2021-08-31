using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFrontEndCore5.Classes;
using WindowsFrontEndCore5.Extensions;
using EntityLibraryCore5.Data;
using EntityLibraryCore5.Models;
using Microsoft.EntityFrameworkCore;
using static WindowsFrontEndCore5.Classes.Dialogs;

namespace WindowsFrontEndCore5
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _supplierBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                using var context = new NorthwindContext();
                var suppliers = await context.Suppliers.AsNoTracking()
                    .OrderBy(supplier => supplier.CompanyName)
                    .ToListAsync();

                _supplierBindingSource.DataSource = suppliers;
                SuppliersComboBox.InvokeIfRequired(combobox => combobox.DataSource = _supplierBindingSource);

                var companies = await context.Customers.AsNoTracking().Select(customer =>
                    new CustomerPartial
                    {
                        Id = customer.CustomerIdentifier,
                        Name = customer.CompanyName
                    }).ToListAsync();


                CompanyComboBox.InvokeIfRequired(combobox => combobox.DataSource = companies);
            });


            RemoveCurrentSupplierButton.Enabled = SuppliersComboBox.Items.Count > 0;
            FilteredCountButton.Enabled = RemoveCurrentSupplierButton.Enabled;
        }

        private void RemoveCurrentSupplierButton_Click(object sender, EventArgs e)
        {
            var currentSupplier = _supplierBindingSource.Current as Suppliers;

            if (!Question($"Remove {currentSupplier.CompanyName}")) return;

            using var context = new NorthwindContext();
            context.Entry(currentSupplier).State = EntityState.Deleted;
            context.SaveChanges();
            _supplierBindingSource.RemoveCurrent();
        }

        private void FilteredCountButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            using var context = new NorthwindContext();
            // active records
            var count = context.Suppliers.AsNoTracking().Count();
            sb.AppendLine($"Not soft deleted: {count}");

            // marked as soft delete
            count = context.Suppliers.IgnoreQueryFilters().AsNoTracking()
                .Count(s => s.Deleted == true);

            sb.AppendLine($"soft deleted: {count}");

            // total count of records
            count = context.Suppliers.IgnoreQueryFilters().AsNoTracking().Count();
            sb.AppendLine($"Total record count: {count}");

            MessageBox.Show(sb.ToString());
        }
    }
}
