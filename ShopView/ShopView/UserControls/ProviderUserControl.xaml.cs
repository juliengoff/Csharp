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
    /// Logique d'interaction pour ProviderUserControl.xaml
    /// </summary>
    public partial class ProviderUserControl : BaseUserControl
    {
        #region Attributes
        private Provider Provider;
        #endregion

        #region Properties
        public Provider provider
        {
            get { return this.Provider; }
            set { this.Provider = value; base.OnPropertyChanged("Provider"); }
        }
        #endregion

        #region Constructor
        public ProviderUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
