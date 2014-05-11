using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CacheSample.DAL.Model;

namespace CacheSample.DAL.Cache
{
    public static class DataContainer
    {
        private static class MyCacheEntries
        {
            public const string Customers = "Customers";
        }

        public CustomersCollection Customers
        {
            get
            {
                object o = HttpContext.Current.Cache[MyCacheEntries.Customers];
                if (o == null)
                {
                    LoadCustomers();
                    o=HttpContext.Current.Cache[MyCacheEntries.Customers];
                }



                return (CustomersCollection)o;
            }
        }

        public CustomersCollection LoadCustomers()
        {

            return new CustomersCollection();
        }
    }
}