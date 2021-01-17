using OnlineShop.Entitiy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Interface.Repository
{
    public interface IProductRepository
    {
        Task<Product> CreateProduct(Product product);

        Task<Product> GetProductById(int id);

        Task<IEnumerable< Product>> GetProductList();

        Task<Product> DeleteProduct(int id);
    }
}
