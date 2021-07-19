using Thrive.Core.Models;

namespace Thrive.UseCases.ViewProduct
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}