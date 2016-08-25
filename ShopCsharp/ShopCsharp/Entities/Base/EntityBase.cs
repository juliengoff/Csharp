using ShopCsharp.MyFaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.Entities.Base
{

    public class EntityBase : INotifyPropertyChanged, eFakerLoader<EntityBase>
    {
        [Key]
        [Column("id")]
        public int Id { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;



        public List<EntityBase> LoadMultipleItems()
        {
            List<EntityBase> result = new List<EntityBase>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }

            return result;
        }



        public EntityBase LoadSingleItem()
        {
            this.Id = Faker.Number.RandomNumber();
            return this; ;
        }


        public void OnPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
