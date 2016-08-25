using ShopView.UserControls;
using ShopView.View.Base;
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

namespace ShopView.View
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        #region Attributes
        #endregion

        #region Properties
        #endregion



        public Page1()
        {
            InitializeComponent();
        }

        private void navigation_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new ClientView());
        }

        private void navigationThrow_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Window1(); //create your new form.
            //newForm.Content = new Page1();
            newForm.Show(); //show the new form.
            Window main = Application.Current.MainWindow as Window;
            main.Close();
        }

        private void navigationframe_Click(object sender, RoutedEventArgs e)
        {
           // (this.Parent as NavigationWindow).Content = new ClientView();
        }
    }
}
