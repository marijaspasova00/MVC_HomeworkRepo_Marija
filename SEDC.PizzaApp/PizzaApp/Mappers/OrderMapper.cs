using PizzaApp.ViewModels.OrderVIewModels;

namespace PizzaApp.Mappers
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel ToDetailsViewModel(this OrderViewModel orderViewModel)
        {
            // Other property mappings
            return new OrderDetailsViewModel
            {
                // Other property assignments
                UserAddress = orderViewModel.UserAddress
            };
        }
    }
}
