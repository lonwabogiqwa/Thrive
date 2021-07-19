using System.Collections.ObjectModel;
using Thrive.Core.Models;

namespace Thrive.UseCases.SearchProduct
{
    public interface ISearchProduct
    {
        ObservableCollection<Product> Execute(string filter = null);
    }
}