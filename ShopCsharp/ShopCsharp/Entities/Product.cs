using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    public class Product : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        private Int32 price;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id");}
        }

        public string Name
        {
            get { return name; }
            set { name = value; this.OnPropertyChanged("Name"); }
        }

        public int Price
        {
            get { return price; }
            set { price = value; this.OnPropertyChanged("Price"); }
        }
        #endregion

        #region Constructor
        public Product()
        {

        }
        public Product(Int32 id, String name, Int32 price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        #endregion
    }
}
