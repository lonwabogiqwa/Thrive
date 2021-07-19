using Thrive.Core.Models;
using Thrive.UseCases.PluginInterfaces.DataStore;

namespace Thrive.UseCases.ViewProduct
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository _productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            var product= _productRepository.GetProduct(id);
            return product;
        }
    }
}
