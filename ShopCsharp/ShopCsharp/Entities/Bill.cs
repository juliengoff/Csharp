using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("bill")]
    public class Bill : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private Client client;
        private List<Product> products;
        private Shop shop;
        #endregion

        #region Properties
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id"); }
        }
        #endregion

        #region Constructor
        public Bill()
        {

        }
        public Bill(Int32 id, Client client, Shop shop)
        {
            this.id = id;
            this.client = client;
            this.shop = shop;
        }
        #endregion



    }
}
