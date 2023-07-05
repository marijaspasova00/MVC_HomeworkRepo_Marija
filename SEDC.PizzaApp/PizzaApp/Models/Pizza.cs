using PizzaApp.Models.Enums;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsOnPromotion { get; set; }

        public string? ImageUrl { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; set; }
    }
}
