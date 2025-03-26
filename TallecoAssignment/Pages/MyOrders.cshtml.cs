using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallecoAssignment.Models;
using TallecoAssignment.Services;

namespace TallecoAssignment.Pages
{
    public class MyOrdersModel : PageModel
    {
        private readonly DataService _dataService;
        public List<Order> Orders { get; set; } = new();

        public MyOrdersModel(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task OnGet()
        {
            Orders = await _dataService.GetOrders();
        }
    }
}
