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
    /// Logique d'interaction pour ProductsUserControl.xaml
    /// </summary>
    public partial class ProductsUserControl : BaseUserControl
    {

        private Product Products;

        public Product products
        {
            get { return this.Products; }
            set { this.Products = value; base.OnPropertyChanged("Products"); }
        }

        public ProductsUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
