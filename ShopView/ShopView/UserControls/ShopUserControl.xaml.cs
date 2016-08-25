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
    /// Logique d'interaction pour ShopUserControl.xaml
    /// </summary>
    public partial class ShopUserControl : BaseUserControl
    {
        #region Attributes
        private Shop Shop;
        #endregion

        #region Properties
        public Shop shop
        {
            get { return this.Shop; }
            set { this.Shop = value; base.OnPropertyChanged("Shop"); }
        }
        #endregion

        #region Constructor
        public ShopUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
