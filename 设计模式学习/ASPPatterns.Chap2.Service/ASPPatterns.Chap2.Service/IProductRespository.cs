using System;
namespace ASPPatterns.Chap2.Service
{
    interface IProductRespository
    {
        System.Collections.Generic.IList<Product> GetAllProductsIn(int categoryId);
    }
}
