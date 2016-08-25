using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities
{
    [Table("address")]
    public class Address : Base.EntityBase
    {
        #region Attributes

        private Int32 id;
        private String street;
        private Int32 sNumber;
        private String city;
        private Int32 postalCode;
        private String country;
        #endregion

        #region Properties
        [Column("id")]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value; this.OnPropertyChanged("Id");
            }
        }
        [Column("street")]
        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value; this.OnPropertyChanged("Street");
            }
        }
        [Column("snumber")]
        public int SNumber
        {
            get
            {
                return sNumber;
            }

            set
            {
                sNumber = value; this.OnPropertyChanged("SNumber");
            }
        }
        [Column("city")]
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value; this.OnPropertyChanged("City");
            }
        }
        [Column("postalcode")]
        public int PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value; this.OnPropertyChanged("PostalCode");
            }
        }
        [Column("country")]
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value; this.OnPropertyChanged("Country");
            }
        }

        #endregion

        #region Constructor
        public Address()
        {

        }

        public Address(Int32 id, String street, Int32 sNumber, String city, Int32 postalCode, String country)
        {
            this.id = id;
            this.street = street;
            this.SNumber = SNumber;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
        }

        public new Address LoadSingleItem()
        {
            Address result = new Address();
            result.Id = Faker.Number.RandomNumber();
            result.Street = Faker.Address.StreetName();
            result.SNumber = Faker.Number.RandomNumber();
            result.City = Faker.Address.USCity();
            result.PostalCode = Faker.Number.RandomNumber();
            result.Country = Faker.Address.Country();

            return result;
        }
        #endregion


    }
}
