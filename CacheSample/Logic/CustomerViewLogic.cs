using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CacheSample.DAL.Cache;
using CacheSample.DAL.Model;

namespace CacheSample.Pages.Logic
{
    public static class CustomerViewLogic
    {

        public static PurchaserCollection Read()
        {

            return DataContainer.GetPurchasers(@"C:\Datas\Purchase\20140101.txt");

        }

    }
}