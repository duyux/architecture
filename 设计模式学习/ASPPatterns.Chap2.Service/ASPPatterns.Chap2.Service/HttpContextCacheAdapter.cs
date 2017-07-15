using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ASPPatterns.Chap2.Service
{
    class HttpContextCacheAdapter:ICacheStorage
    {
        void ICacheStorage.Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        void ICacheStorage.Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        T ICacheStorage.Retrieve<T>(string key)
        {
            T itemStored =(T) HttpContext.Current.Cache.Get(key);
            if(itemStored==null)
            {
                itemStored=default(T);
            }
            return itemStored;
        }
    }
}
