using System.Collections.ObjectModel;
using Thrive.Core.Models;

namespace Thrive.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        ObservableCollection<Product> GetProducts(string filter = null);
        Product CreateProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
