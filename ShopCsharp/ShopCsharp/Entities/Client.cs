using ShopCsharp.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("client")]
    public class Client : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String firstname;
        private String lastname;
        private Address address;
        private Int32 bill;
        private Int32 money;
        private List<Product> shopCart;
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
            get {  return firstname; }
            set { firstname = value; this.OnPropertyChanged("Firstname"); }
        }
        [Column("lastname")]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; this.OnPropertyChanged("Lastname"); }
        }
        [Column("bill")]
        public int Bill
        {
            get { return bill; }
            set { bill = value; this.OnPropertyChanged("Bill"); }
        }
        [Column("money")]
        public int Money
        {
            get { return money; }
            set { money = value; this.OnPropertyChanged("Money"); }
        }
        #endregion


        #region Constructor
        public Client()
        {

        }
        public Client(Int32 id, String firstname, String lastname, Int32 bill, Int32 money)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.bill = bill;
            this.money = money;
        }
        #endregion

        public new List<Client> LoadMultipleItems()
        {
            List<Client> result = new List<Client>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }

            return result;
        }



        public new Client LoadSingleItem()
        {
            this.Id = Faker.Number.RandomNumber();
            return this; ;
        }
    }
}