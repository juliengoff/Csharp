using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("order")]
    public class Order : Base.EntityBase
    {
        #region Attrbutes
        private Int32 id;
        private Client client;
        private Shop shop;
        private Bill bill;
        private List<Product> products;
        #endregion


        #region Properties
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id"); }
        }
        [Column("client")]
        internal Client Client
        {
            get { return client; }
            set { client = value; this.OnPropertyChanged("Client"); }
        }
        [Column("shop")]
        internal Shop Shop
        {
            get { return shop; }
            set { shop = value; this.OnPropertyChanged("Shop"); }
        }
        #endregion

        #region Constructor
        public Order()
        {

        }
        public Order(Int32 id, Client client, Shop shop, Bill bill)
        {
            this.id = id;
            this.client = client;
            this.shop = shop;
            this.bill = bill;
        }  
        #endregion
    }
}
