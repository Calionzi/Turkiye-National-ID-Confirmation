using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkiye_National_ID_Confirmation
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public bool KimlikNoKontrol(long tckn)
        {
            bool durum = false;
            if (tckn.ToString().Length == 11)
            {
                long ilk9 = tckn / 100;
                long son2 = tckn % 100;
                long tekler = 0, ciftler = 0;
                for (int i = 1; i < 10; i++)
                {
                    long basamak = ilk9 % 10;
                    if (i % 2 == 0)
                    {
                        ciftler += basamak;
                    }
                    else
                    {
                        tekler += basamak;
                    }
                    ilk9 /= 10;
                }
                long basamak10 = (tekler * 7 - ciftler) % 10;
                long basamak11 = (tekler + ciftler + basamak10) % 10;
                return son2 == basamak10 * 10 + basamak11;
            }
            return durum;
        }
}
