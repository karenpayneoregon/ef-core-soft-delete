using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFrontEnd.Classes;
using WindowsFrontEnd.Extensions;
using EntityLibrary;
using EntityLibrary.Extensions;
using EntityLibrary.Interfaces;
using Microsoft.EntityFrameworkCore;
using static WindowsFrontEnd.Classes.Dialogs;

namespace WindowsFrontEnd
{
    /// <summary>
    /// Note since all read data are in ComboBox controls and meant
    /// for use in a real application for filtering or setting a
    /// property when editing or adding a record local instances
    /// of the dbContext are used. There is an example for removing
    /// a entity from a ComboBox which would not happen in the wild,
    /// this is for demonstrating how to soft delete.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }
        private readonly BindingSource _supplierBindingSource = new BindingSource();
        /// <summary>
        /// Read data asynchronously for keeping the app responsive on slower
        /// computers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Shown(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                using (var context = new NorthwindContext())
                {
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
                }

            });


            RemoveCurrentSupplierButton.Enabled = SuppliersComboBox.Items.Count > 0;
            FilteredCountButton.Enabled = RemoveCurrentSupplierButton.Enabled;
        }

        private void RemoveCurrentSupplierButton_Click(object sender, EventArgs e)
        {

            var currentSupplier = _supplierBindingSource.Current as Suppliers;

            if (!Question($"Remove {currentSupplier.CompanyName}")) return;

            using (var context = new NorthwindContext())
            {
                context.Entry(currentSupplier).State = EntityState.Deleted;
                context.SaveChanges();
                _supplierBindingSource.RemoveCurrent();
            }

        }
        /// <summary>
        /// Show filter counts on suppliers model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilteredCountButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            using (var context = new NorthwindContext())
            {
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
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
