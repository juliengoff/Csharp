using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("owner")]
    public class Owner : Base.EntityBase
    {
        #region Attributes
        private Int32 id;
        private String firstname;
        private String lastname;
        private Address address;
        #endregion

        #region Properties
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; this.OnPropertyChanged("Id"); }
        }
        [Column("firstname")]
        public string Firstname
        {
            get { return firstname;}
            set { firstname = value; this.OnPropertyChanged("Firstname"); }
        }
        [Column("lastname")]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; this.OnPropertyChanged("Lastname"); }
        }
        #endregion

        #region Constructor
        public Owner()
        {

        }

        public Owner(Int32 id, String firstname, String lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        #endregion
    }
}
