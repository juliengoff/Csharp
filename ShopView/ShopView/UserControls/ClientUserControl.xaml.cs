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
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public sealed partial class ClientUserControl : BaseUserControl
    {
        #region Attributes
        private Client client;
        #endregion

        #region Properties

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; base.OnPropertyChanged("Client"); }
        }
        #endregion


        #region Constructor
        public ClientUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
