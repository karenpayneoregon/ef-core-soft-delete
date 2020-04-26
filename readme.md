# Entity Framework Core 3x soft deletables

This repository contains code to show how to use HasQueryFilter to provide soft deletes against any model which implements a specific Interface.

Microsoft TechNet article

![screenshot](assets/softdelete1.png)

### Setup
- Run [the following script](https://github.com/karenpayneoregon/ef-core-soft-delete/blob/master/EntityLibrary/DataScripts/script.sql) to create the database and populate tables.
- From Visual Studio solution explorer select Restore Nuget packages.
- Ensure WindowsFrontEnd is the startup project.
- Build the solution
- Run

### Requires
- Microsoft Framework 4.7.2 or higher
- Microsoft Visual 2017 or higher
- Microsoft SQL-Server 2012 or higher 

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