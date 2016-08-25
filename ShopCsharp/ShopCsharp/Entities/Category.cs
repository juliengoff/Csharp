using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("category")]
    public class Category : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        #endregion

        #region Properties
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id"); }
        }
        [Column("name")]
        public string Name
        {
            get { return name; }
            set { name = value; this.OnPropertyChanged("Name"); }
        }
        #endregion

        #region Constructor
        public Category()
        {

        }

        public Category(Int32 id, String name)
        {
            this.id = id;
            this.name = name;
        }
        #endregion
    }
}
