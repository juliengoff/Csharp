using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    public class Shop : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private Address address;
        private Owner owner;
        private List<Client> clients;
        private List<Product> products;
        private List<Order> orders;
        private List<Provider> providers;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id");}
        }

        internal Address Address
        {
            get {  return address; }
            set { address = value; this.OnPropertyChanged("Address");}
        }

        internal Owner Owner
        {
            get {  return owner; }
            set { owner = value; this.OnPropertyChanged("Owner"); }
        }

        public List<Client> Clients
        {
            get
            {
                return this.clients;
            }

            set
            {
                this.clients = value; OnPropertyChanged("Clients");
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }

            set
            {
                this.products = value; OnPropertyChanged("Products");
            }
        }

        public List<Order> Orders
        {
            get
            {
                return this.orders;
            }

            set
            {
                this.orders = value; OnPropertyChanged("Orders");
            }
        }

        public List<Provider> Providers
        {
            get
            {
                return this.providers;
            }

            set
            {
                this.providers = value; OnPropertyChanged("Providers");
            }
        }
        #endregion

        #region Constructor
        public Shop()
        {

        }

        public Shop(Int32 id, Address address, Owner owner)
        {
            this.id = id;
            this.address = address;
            this.owner = owner;
        }
        #endregion
    }
}
