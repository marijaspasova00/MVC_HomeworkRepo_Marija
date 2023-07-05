using PizzaApp.ViewModels.PizzaViewModels;

namespace PizzaApp.ViewModels.OrderVIewModels
{
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<PizzaViewModel> Pizzas { get; set; }
        public string UserAddress { get; set; }
    }

}
