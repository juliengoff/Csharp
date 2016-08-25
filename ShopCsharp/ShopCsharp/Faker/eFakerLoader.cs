using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCsharp.MyFaker
{
    public interface eFakerLoader<T>
    {
        T LoadSingleItem();
        List<T> LoadMultipleItems();
    }
}
