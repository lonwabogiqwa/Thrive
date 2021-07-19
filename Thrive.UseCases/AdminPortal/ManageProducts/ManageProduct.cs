using Thrive.Core.Models;
using Thrive.UseCases.PluginInterfaces.DataStore;

namespace Thrive.UseCases.AdminPortal.ManageProducts
{
    public class ManageProduct : IManageProduct
    {
        private readonly IProductRepository _productRepository;

        public ManageProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Execute(Product product)
        {
            var result = _productRepository.CreateProduct(product);

            return result;

        }

        public Product UpdateProduct(Product product)
        {
         var result  = _productRepository.UpdateProduct(product);
         return result;

        }

        public bool DeleteProduct(int id)
        {
          var result=  _productRepository.DeleteProduct(id);
            return result;
        }
    }
}
