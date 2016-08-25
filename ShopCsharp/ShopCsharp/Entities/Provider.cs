using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    public class Provider : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        private Address address;
        private String phone;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id"); }
        }

        public string Name
        {
            get { return name;}
            set { name = value; this.OnPropertyChanged("Name"); }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; this.OnPropertyChanged("Phone"); }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; this.OnPropertyChanged("Address"); }
        }
        #endregion

        #region Constructor
        public Provider()
        {

        }
        public Provider(Int32 id, String name, String phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;

        }
        #endregion
    }
}
