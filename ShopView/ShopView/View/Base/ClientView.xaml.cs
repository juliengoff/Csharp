using ShopView.UserControls;
using ShopView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopView.View.Base
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : Page
    {
        #region Attributes
        private ClientViewModel clientViewModel;
        #endregion

        #region Properties
        public ClientUserControl ClientUserControl { get; set; }
        public ProductsUserControl ProductUserControl { get; set; }
        #endregion


        public ClientView(ClientViewModel clientViewModel)
        {
            InitializeComponent();
            this.clientViewModel = clientViewModel;
        }

        private void navigation_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
