using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CacheSample.DAL.Model;
using System.Web.Caching;
namespace CacheSample.DAL.Cache
{
    public static class DataContainer
    {
        private static class MyCacheEntries
        {
            public const string Purchasers = "Purchasers";
        }

        /// <summary>
        /// Purchasersの取得
        /// 日付単位でキャッシュ
        /// </summary>
        public static PurchaserCollection GetPurchasers(String filename)
        {
            object o = HttpContext.Current.Cache[filename];
            
            if(o==null)
            {
                 LoadPurchasers(filename);
                 o=HttpContext.Current.Cache[filename];
            }

            return (PurchaserCollection)o;
        }

        /// <summary>
        /// 日付指定したPurchasersをキャッシュにロード
        /// </summary>
        /// <returns></returns>
        private static void LoadPurchasers(String filename)
        {
            var pc=PurchaserCollection.Load(filename);
            
            //キャッシュを一時間で破棄 Cacheオブジェクトの優先度は低
            //(サーバがシステムメモリを解放するときに最初に削除される
            HttpContext.Current.Cache.Insert(filename, pc, new CacheDependency(filename),
                                                System.Web.Caching.Cache.NoAbsoluteExpiration, 
                                                    TimeSpan.FromHours(1)
                                                    ,CacheItemPriority.Low,null);

        }
    }
}