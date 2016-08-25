using ShopCsharp.Entities;
using ShopView.UserControls.Base;
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

namespace ShopView.UserControls
{
    /// <summary>
    /// Logique d'interaction pour AddressUserControl.xaml
    /// </summary>
    public partial class AddressUserControl : BaseUserControl
    {

        #region Attributes
        private AddressUserControl address;
        #endregion

        #region Properties
        /*public Address Address
        {
            get { return this.address; }
            set { this.address = value; base.OnPropertyChanged("Address"); }
        //}*/
        #endregion




        public AddressUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
