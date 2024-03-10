// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CinemaGo.Admin.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\Pages\Category.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\Pages\Category.razor"
using CinemaGo.Admin.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Category : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 174 "C:\Users\mirla\Documents\GitHub\cinema-go-streamer\CinemaGo.Admin\Pages\Category.razor"
       
    [CascadingParameter]
    public EventCallback notify { get; set; }

    public CategoryModel categoryModel { get; set; }

    public List<CategoryModel> categoryList { get; set; }

    public CategoryModel categoryToUpdate { get; set; }

    public CategoryModel categoryToDelete { get; set; }

    public bool showEditPopup = false;

    public bool showDeletePopup = false;

    public bool successPopup = false;

    public string Message = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        categoryModel = new CategoryModel();
        await GetCategories();

    }

    private async Task SaveCategory()
    {
        await adminPanelService.SaveCategory(categoryModel);
        Message = "Category Added Successfully !";
        ToggleSuccessPopup();
        categoryModel = new CategoryModel();
        await GetCategories();
    }

    private async Task UpdateCategory()
    {
        bool flag = await adminPanelService.UpdateCategory(categoryToUpdate);
        ToggleEditPopup();
        if (flag)
        {
            Message = "Category Updated Successfully !";
        }
        else
        {
            Message = "Category Not Updated Try Again!";
        }

        ToggleSuccessPopup();
        categoryToUpdate = new CategoryModel();
        await GetCategories();
    }

    private async Task DeleteCategory()
    {
        bool flag = await adminPanelService.DeleteCategory(categoryToDelete);
        ToggleDeletePopup();
        if (flag)
        {
            Message = "Category Deleted Successfully !";
        }
        else
        {
            Message = "Category Not Deleted Try Again!";
        }

        ToggleSuccessPopup();
        categoryModel = new CategoryModel();
        await GetCategories();
    }
    private async Task GetCategories()
    {
        categoryList = await adminPanelService.GetCategories();
    }

    private void ClearForm()
    {
        categoryModel = new CategoryModel();
    }


    private void EditButtonClick(CategoryModel _categoryToUpdate)
    {
        categoryToUpdate = _categoryToUpdate;
        ToggleEditPopup();
    }

    private void DeleteButtonClick(CategoryModel _categoryToDelete)
    {
        categoryToDelete = _categoryToDelete;
        ToggleDeletePopup();
    }

    private void ToggleEditPopup()
    {
        showEditPopup = showEditPopup == true ? false : true;
    }

    private void ToggleDeletePopup()
    {
        showDeletePopup = showDeletePopup == true ? false : true;
    }

    private void ToggleSuccessPopup()
    {
        successPopup = successPopup == true ? false : true;
    }



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591
