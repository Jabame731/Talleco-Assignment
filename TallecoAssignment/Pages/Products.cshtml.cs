using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallecoAssignment.Models;
using TallecoAssignment.Services;

namespace TallecoAssignment.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly DataService _dataService;
        public List<Product> Products { get; set; }

        public ProductsModel(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task OnGet()
        {
            Products = await _dataService.GetProducts();
        }
    }
}
