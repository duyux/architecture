using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASPPatterns.Chap2.Service
{
    class ProductService
    {
        private IProductRespository _productRespository;
        private ICacheStorage _cacheStorage;

        public ProductService(IProductRespository productRespository,ICacheStorage cacheStorage)
        {
            _productRespository = productRespository;
            _cacheStorage=cacheStorage;
        }
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products;
            string storageKey = string.Format("products_in_category_id{0}",categoryId);

           // products = (List<Product>)System.Web.HttpContext.Current.Cache.Get(storageKey);
            products=_cacheStorage.Retrieve<List<Product>>(storageKey);

            if (products == null)
            {
                products = _productRespository.GetAllProductsIn(categoryId);
                //System.Web.HttpContext.Current.Cache.Insert(storageKey, products);
                _cacheStorage.Store(storageKey,products);
            }

            return products;


        }
    }
}
