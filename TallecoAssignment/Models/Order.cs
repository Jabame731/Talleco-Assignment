using System.Text.Json.Serialization;

namespace TallecoAssignment.Models
{
    public class OrderItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("siteId")]
        public int SiteId { get; set; }

        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; } = string.Empty;

        [JsonPropertyName("retailCost")]
        public int RetailCost { get; set; }

        [JsonPropertyName("accountDiscount")]
        public int AccountDiscount { get; set; }

        [JsonPropertyName("netCost")]
        public int NetCost { get; set; }

        [JsonPropertyName("jobData")]
        public JobData? JobData;


    }

    public class Order
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("recruiterId")]
        public int RecruiterId { get; set; }

        [JsonPropertyName("divisionId")]
        public int DivisionId { get; set; }

        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [JsonPropertyName("validated")]
        public bool Validated { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; } = string.Empty;

        [JsonPropertyName("completed")]
        public string Completed { get; set; } = string.Empty;

        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; } = new();

    }

    public class JobData
    {
        [JsonPropertyName("jobId")]
        public int JobId { get; set; }

        [JsonPropertyName("postingId")]
        public int PostingId { get; set; }
    }
}
