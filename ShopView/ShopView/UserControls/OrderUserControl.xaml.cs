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
    /// Logique d'interaction pour OrderUserControl.xaml
    /// </summary>
    public partial class OrderUserControl : BaseUserControl
    {
        #region Attributes
        private Order order;
        #endregion

        #region Properties
        public Order Order
        {
            get { return this.order; }
            set { this.order = value; base.OnPropertyChanged("Order"); }
        }
        #endregion

        #region Constructor
        public OrderUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
