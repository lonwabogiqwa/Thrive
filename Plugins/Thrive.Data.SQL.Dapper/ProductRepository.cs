using System.Collections.ObjectModel;
using Thrive.Core.Models;
using Thrive.Data.SQL.Dapper.Helpers;
using Thrive.UseCases.PluginInterfaces.DataStore;

namespace Thrive.Data.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess _dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public Product CreateProduct(Product product)
        {
            // create product
            const string sql = @"INSERT INTO [dbo].[Product]
           ([Brand]
           ,[Name]
           ,[Price]
           ,[Image]
           ,[Description])
                
                 VALUES
                       (@Brand
                        ,@Name
                        ,@Price
                        ,@Image
                        ,@Description);
SELECT CAST(SCOPE_IDENTITY() as int)";




            _dataAccess.ExecuteCommand(sql, product);

            return product;

        }

        public Product UpdateProduct(Product product)
        {
            // update product
            const string sql = @"UPDATE [Product]
                          SET [Brand] = @Brand
                          ,[Name] = @Name
                          ,[Price] = @Price
                          ,[Image] = @Image
                          ,[Description] = @Description
                           WHERE ProductId = @ProductId";

            _dataAccess.ExecuteCommand<Product>(sql, product);
            return product;
        }

        public bool DeleteProduct(int id)
        {
            // delete product
            const string sql = @"DELETE FROM [dbo].[Product]
      WHERE ProductId= @ProductId ";

           var result= _dataAccess.Query<Product,dynamic>(sql, new { ProductId =id});
           return result==null || result.Count==0;
        }


        public Product GetProduct(int id)
        {
          var product= _dataAccess.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId = @ProductId", new { ProductId = id });
          return product;
        }

        public ObservableCollection<Product> GetProducts(string filter)
        {
            var list = string.IsNullOrWhiteSpace(filter)
                ? _dataAccess.Query<Product, dynamic>("SELECT * FROM Product", new { })
                : _dataAccess.Query<Product, dynamic>("SELECT * FROM Product WHERE Name like '%' + @Filter + '%'",
                    new { Filter = filter });

            return new ObservableCollection<Product>(list);
        }
    }
}
