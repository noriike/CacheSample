using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheSample.DAL.Model
{
    public class Purchaser
    {
        public DateTime datetime { get; set; }

        public String CustomerID { get; set; }

        public String ItemId { get; set; }

        public Purchaser(DateTime d,String customerid,String itemid)
        {
            this.datetime = d;
            this.CustomerID = customerid;
            this.ItemId = itemid;
        }

    }
}
