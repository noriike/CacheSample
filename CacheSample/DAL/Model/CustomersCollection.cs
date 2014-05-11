using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace CacheSample.DAL.Model
{
    public class PurchaserCollection:List<Purchaser>
    {
        public static PurchaserCollection Load(String filename)
        {
            PurchaserCollection pc = new PurchaserCollection();

            using (StreamReader reader = new StreamReader(filename))
            {
                String[] c;
                while (!reader.EndOfStream)
                {
                    c=reader.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    pc.Add(new Purchaser(DateTime.Parse(c[0]), c[1], c[2]));
                }
            }

            return pc;
        }
    }
}