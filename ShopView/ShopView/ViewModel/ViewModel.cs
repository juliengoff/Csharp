using ShopCsharp.JSON;
using ShopView.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopView.ViewModel
{
    public class ViewModel
    {
        #region Attributes
        private ViewModel page1;

        public object myView { get; private set; }
        #endregion

        #region constructor

        #endregion

        #region methods
        SandBox sb = new SandBox();
        #endregion

        /*Task.Factory.StartNew(() => 
        {
            this.Page1.ClientUserControl.Client = new ClientViewModel().loadSingleItem();
            ApplicationException.Current.Dispatcher.INvoke(DispatcherPriority.Background, 
            new ThreadStart(delegate {
            
                for (int i = 0; i<length; i++)
			    {
                     this.Page1.ClientUserControl.Background = new SolidBrush(ConsoleColor.FromRgb(255, 40, 28));
			    }
               
            }));
        });

        int a = 0;
        a++;*/
    }


}