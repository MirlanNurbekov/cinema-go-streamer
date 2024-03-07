using CinemaGo.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Net.Http;

namespace CinemaGo.Admin.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient httpClient;

        public AdminPanelService (HttpClient _httpClient) 
        {
            this.httpClient = _httpClient;
        }
        public async Task<ResponseModel>AdminLogin(LoginModel loginModel)
        {
            return await httpClient.PostJsonAsync<ResponseModel>("api/admin/AdminLogin", loginModel);
        }
        

        public async Task<CinemaModel> SaveCinema(CinemaModel newCinema)
        {
            return await httpClient.PostJsonAsync<CinemaModel>("api/admin/SaveCinema", newCinema);
        }

        public async Task<List<CinemaModel>> GetCinemas()
        {
            return await httpClient.GetJsonAsync<List<CinemaModel>>("api/admin/GetCinemas");
        }

        public async Task<bool> UpdateCinema(CinemaModel cinemaToUpdate)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/UpdateCinema", cinemaToUpdate);
        }

        public async Task<bool> DeleteCinema(CinemaModel cinemaToDelete)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/DeleteCinema", cinemaToDelete);
        }

        public async Task<CategoryModel> SaveCategory(CategoryModel newCategory)
        {
            return await httpClient.PostJsonAsync<CategoryModel>("api/admin/SaveCategory", newCategory);
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            return await httpClient.GetJsonAsync<List<CategoryModel>>("api/admin/GetCategories");
        }

        public async Task<bool> UpdateCategory(CategoryModel categoryToUpdate) 
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/UpdateCategory", categoryToUpdate);
        }
        public async Task<bool> DeleteCategory(CategoryModel categoryToDelete) 
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/DeleteCategory", categoryToDelete);
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            return await httpClient.GetJsonAsync<List<ProductModel>>("api/admin/GetProducts");
        }

        public async Task<bool> DeleteProduct(ProductModel productToDelete)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/DeleteProduct", productToDelete);
        }

        public async Task<ProductModel> SaveProduct(ProductModel newProduct) 
        {
            return await httpClient.PostJsonAsync<ProductModel>("api/admin/SaveProduct", newProduct);
        }

        public async Task<List<StockModel>> GetProductStock()
        {
            return await httpClient.GetJsonAsync<List<StockModel>>("api/admin/GetProductStock");
        }
        public async Task<bool>UpdateProductStock(StockModel stock)
        {
            return await httpClient.PostJsonAsync<bool>("api/admin/UpdateProductStock", stock);
        }
    }
}