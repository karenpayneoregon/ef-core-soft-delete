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
using Microsoft.EntityFrameworkCore;
using static WindowsFrontEnd.Classes.Dialogs;

namespace WindowsFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                using (var context = new NorthwindContext())
                {
                    var suppliers = await context.Suppliers.AsNoTracking()
                        .OrderBy(supplier => supplier.CompanyName)
                        .ToListAsync();

                    SuppliersComboBox.InvokeIfRequired(combobox => combobox.DataSource = suppliers);

                    var companies = await context.Customers.AsNoTracking().Select(customer =>
                        new CustomerPartial
                        {
                            Id = customer.CustomerIdentifier,
                            Name = customer.CompanyName
                        }).ToListAsync();

                    
                    CompanyComboBox.InvokeIfRequired(comboxbox => comboxbox.DataSource = companies);
                }

            });


            RemoveCurrentSupplierButton.Enabled = SuppliersComboBox.Items.Count > 0;
        }

        private void RemoveCurrentSupplierButton_Click(object sender, EventArgs e)
        {
            var currentSupplier = SuppliersComboBox.SelectedItem as Suppliers;

            using (var context = new NorthwindContext())
            {
                context.Entry(currentSupplier).State = EntityState.Deleted;
                context.SaveChanges();
            }

            return;
            if (Question($"Remove {currentSupplier.CompanyName}"))
            {
                using (var context = new NorthwindContext())
                {
                    context.Entry(currentSupplier).SoftDelete();
                    context.SaveChanges();
                }
            }

        }
    }
}
