# Entity Framework Core 3x soft deletables

This repository contains code to show how to use HasQueryFilter to provide soft deletes against any model which implements a specific Interface.

Microsoft TechNet article

![screenshot](assets/softdelete1.png)



```csharp
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
```