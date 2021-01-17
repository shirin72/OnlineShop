using OnlineShop.Entitiy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Interface.Repository
{
    public  interface IProductCategory
    {
        Task<ProductCategory> CreateProductCategory(ProductCategory productCategory);

        Task<ProductCategory> GetProductCategoryById(int id);

        Task<IEnumerable<ProductCategory>> GetProductCategoryList();

        Task<ProductCategory> DeleteProductCategory(int id);
    }
}
