using CinemaGo.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaGo.Admin.Services
{
    public interface IAdminPanelService
    {
        Task<ResponseModel> AdminLogin(LoginModel loginModel);
        Task<CinemaModel> SaveCinema(CinemaModel newCinema);
        Task<List<CinemaModel>> GetCinemas();

        Task<bool> UpdateCinema(CinemaModel cinemaToUpdate);

        Task<bool> DeleteCinema(CinemaModel cinemaToDelete);
        Task<CategoryModel> SaveCategory(CategoryModel newCategory);
        Task<List<CategoryModel>> GetCategories();

        Task<bool> UpdateCategory(CategoryModel categoryToUpdate);

        Task<bool> DeleteCategory(CategoryModel categoryToDelete);

        Task<List<ProductModel>> GetProducts();
        Task<bool> DeleteProduct(ProductModel productToDelete);
        Task<ProductModel> SaveProduct(ProductModel newProduct);

        Task<List<StockModel>> GetProductStock();

        Task<bool> UpdateProductStock(StockModel stock);

        

        
    }
}