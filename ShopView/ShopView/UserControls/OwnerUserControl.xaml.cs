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
    /// Logique d'interaction pour OwnerUserControl.xaml
    /// </summary>
    public partial class OwnerUserControl : BaseUserControl
    {
        #region Attributes
        private Owner owner;
        #endregion

        #region Properties
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; base.OnPropertyChanged("Owner"); }
        }
        #endregion

        #region Constructor
        public OwnerUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

    }
}
