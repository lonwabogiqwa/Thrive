using Thrive.Core.Models;

namespace Thrive.UseCases.AdminPortal.ManageProducts
{
    public interface IManageProduct
    {
        Product Execute(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}