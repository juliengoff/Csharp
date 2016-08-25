using ShopCsharp.Database;
using ShopCsharp.Entities;
using ShopCsharp.EnumManager;
using ShopView.View.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace ShopView.ViewModel
{
    public class ClientViewModel
    {
        #region Attributes
        private ClientView clientView;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ClientViewModel(ClientView clientView)
        {
            this.clientView = clientView;
            //LoadItems();
            //LinkItems();

            MySQLManager<Client> client1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYQSL);

            testc();
        }

        private void testc()
        {
            Task.Factory.StartNew(() =>
            {
                this.clientView.ClientUserControl.Client = new Client().LoadSingleItem();
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                new ThreadStart(delegate {

                    for (int i = 0; i < 100; i++)
                    {
                        this.clientView.ClientUserControl.Background = new SolidColorBrush(Color.FromRgb(255, 40, 28));
                    }

                }));
            });

            int a = 0;
            a++;
        }
        #endregion

    }
}
