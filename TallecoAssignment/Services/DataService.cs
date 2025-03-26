using System.Text.Json;
using TallecoAssignment.Models;

namespace TallecoAssignment.Services
{
    public class DataService
    {
        private readonly IWebHostEnvironment _env;

        public DataService(IWebHostEnvironment env)
        {
            _env = env;
        }


        public async Task<List<Product>> GetProducts()
        {
            string filePath = Path.Combine(_env.WebRootPath, "data", "products.json");

            if (!File.Exists(filePath)) return new List<Product>();

            string json = await File.ReadAllTextAsync(filePath);

            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();

        }


        public async Task<List<Order>>  GetOrders()
        {
            string filePath = Path.Combine(_env.WebRootPath, "data", "orders.json");
            if (!File.Exists(filePath)) return new List<Order>();

            string json = await File.ReadAllTextAsync(filePath);

            return JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
        }
    }
}
