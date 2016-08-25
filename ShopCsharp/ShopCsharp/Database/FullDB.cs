using ShopCsharp.Entities;
using ShopCsharp.EnumManager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    class FullDB : DbContext
    {
        #region Singleton
        private static volatile FullDB instance;
        private static object syncRoot = new Object();
        
        
        private FullDB() { }

        public static FullDB Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FullDB();
                    }
                }

                return instance;
            }
        }
        #endregion
        

        public DbSet<Address> DbSetAddress { get; set; }
        public DbSet<Bill> DbSetBill { get; set; }
        public DbSet<Category> DbSetCategory { get; set; }
        public DbSet<Client> DbSetClient { get; set; }
        public DbSet<Order> DbSetOrder { get; set; }
        public DbSet<Owner> DbSetOwner { get; set; }
        public DbSet<Product> DbSetProduct { get; set; }
        public DbSet<Provider> DbSetProvider { get; set; }
        public DbSet<Shop> DbSetShop { get; set; }

        public FullDB(DataConnectionResource dataConnectionResource): base(EnumString.GetStringValue(dataConnectionResource))
        {
            this.Database.CreateIfNotExists();
        }
    }
}
