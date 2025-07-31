using WebAPI_ECOMMERCE.Entities;

namespace WebAPI_ECOMMERCE.Repository
{
    public interface InterfaceProduct
    {
        Task Add(ProductModel Objeto);
        Task Update(ProductModel Objeto);
        Task Delete(ProductModel Objeto);
        Task<ProductModel> GetEntiryById(int Id);
        Task<List<ProductModel>> List();

    }
}
