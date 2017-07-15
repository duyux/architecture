using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap2.Service
{
    class ProductRespository : ASPPatterns.Chap2.Service.IProductRespository
    {
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products = new List<Product>();
            //Database operation to polulate products
            return products;
        }
    }
}
