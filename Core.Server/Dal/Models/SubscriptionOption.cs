using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Server.Dal.Models
{
    public class SubscriptionOption
    {
        public int SubscriptionOptionId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}