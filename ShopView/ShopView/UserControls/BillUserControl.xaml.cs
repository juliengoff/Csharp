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
    /// Logique d'interaction pour Bill.xaml
    /// </summary>
    public partial class Bill : BaseUserControl
    {
        #region Attributes
        private Bill bill;
        #endregion

        #region Properties
        public Bill Bill1
        {
            get { return this.bill; }
            set { this.bill = value; base.OnPropertyChanged("Bill"); }
        }
        #endregion

        #region Constructor
        public Bill()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
