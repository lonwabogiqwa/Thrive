using System.Collections.ObjectModel;
using Thrive.Core.Models;
using Thrive.UseCases.PluginInterfaces.DataStore;

namespace Thrive.UseCases.SearchProduct
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository _productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public ObservableCollection<Product> Execute(string filter = null)
        {
            return _productRepository.GetProducts(filter);
        }
    }
}
