using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDrug.ViewController
{
    internal class SalesTabController : ITabController<int[]>
    {
        public TextBox StartMonth { get; set; }
        public TextBox EndMonth { get; set;}
        public TextBox StartYear { get; set; }
        public TextBox EndYear { get; set;}

        public void clearAll()
        {
            StartMonth.Clear();
            EndMonth.Clear();
            StartYear.Clear();
            EndYear.Clear();
        }

        public int[] createObject()
        {
            int[] res = {1,2,2011,2012};

            try
            {
                res[0] = int.Parse(this.StartMonth.Text.Trim());
                res[1] = int.Parse(EndMonth.Text.Trim());
                res[2] = int.Parse(StartYear.Text.Trim());
                res[3] = int.Parse(EndYear.Text.Trim());
                return res;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return res;
            }
        }
        public int NumberNewRows()
        {
            throw new NotImplementedException();
        }

        public void resetRows()
        {
            throw new NotImplementedException();
        }
    }
}
