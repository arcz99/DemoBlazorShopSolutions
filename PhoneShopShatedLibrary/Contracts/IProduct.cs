using PhoneShopShatedLibrary.Models;
using PhoneShopShatedLibrary.Responses;


namespace PhoneShopShatedLibrary.Contracts
{
    public interface IProduct
    {
        Task<ServiceResponse> AddProduct(Product model);
        Task<List<Product>> GetAllProducts(bool featuredProducts);
    }
}
