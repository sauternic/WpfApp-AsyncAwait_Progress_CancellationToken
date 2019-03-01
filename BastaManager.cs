using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WpfApp2
{
    public class BastaManager
    {
        public List<string> LoadSpeakers()
        {
            var list = new List<string>();
            for(int x = 1; x <= 10; x++)
            {
                Thread.Sleep(500);
                list.Add("Nicolas " + x.ToString());
            }
            return list;
        }

        public List<string> LoadSeesions()
        {
            Thread.Sleep(3000);
            var list = new List<string>();
            for (int x = 1; x <= 10; x++)
            {
                list.Add("Session " + x.ToString());
            }
            return list;
        }
    }
}
