using Newtonsoft.Json;
using ShopCsharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.JSON
{
    public class SandBox
    {

        public void TestIt()
        {
            Client client = new Client();
            client.Id = 1;
            client.Firstname = "johnny";
            client.Lastname = "ducon";
            client.Money = 2;


            String convertClient = JsonConvert.SerializeObject(client);

           //Order order = new Order().LoadMultipleItems();
           //String convertOrder = JsonConvert.SerializeObject(order);

            Client clientRevert = JsonConvert.DeserializeObject<Client>(convertClient);

            List<Client> clientList = JsonConvert.DeserializeObject<List<Client>>(convertClient);
        }
        
    }
}
