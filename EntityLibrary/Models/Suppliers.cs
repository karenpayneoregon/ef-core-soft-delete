using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using EntityLibrary.Interfaces;

namespace EntityLibrary
{
    public partial class Suppliers : ISoftDelete, INotifyPropertyChanged
    {
        private bool? _deleted;

        public Suppliers()
        {
            Products = new HashSet<Products>();
        }

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }

        public bool? Deleted
        {
            get => _deleted;
            set
            {
                _deleted = value;
                OnPropertyChanged();
            }
        }

        public virtual ICollection<Products> Products { get; set; }

        [NotMapped]
        public bool IsDeleted
        { 
            get => (bool) Deleted;
            set => Deleted = value;
        }

        public override string ToString() => CompanyName;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}