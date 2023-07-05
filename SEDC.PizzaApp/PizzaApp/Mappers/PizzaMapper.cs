using PizzaApp.Models;
using PizzaApp.ViewModels.PizzaViewModels;

namespace PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToViewModel(this Pizza pizza)
        {
            decimal priceWithExtras = pizza.HasExtras ? pizza.Price + 10 : pizza.Price;

            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = priceWithExtras,
                PizzaSize = pizza.PizzaSize
            };
        }
    }

}
