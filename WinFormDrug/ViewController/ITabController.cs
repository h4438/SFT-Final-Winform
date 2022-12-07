using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    public interface ITabController<T>
    {
        T createObject();
        void clearAll();

        int NumberNewRows();
        void resetRows();
    }
}
