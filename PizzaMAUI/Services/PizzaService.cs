using PizzaMAUI.Models;

namespace PizzaMAUI.Services
{
    public class PizzaService
    {
        private readonly static IEnumerable<Pizza> _pizzas = new List<Pizza>
        {
            new Pizza
            {
                Name = "Pizza 1",
                Image = "pizza1img",
                Price = 5.1
            },
            new Pizza
            {
                Name = "Pizza 2",
                Image = "pizza2img",
                Price = 2.5
            },
            new Pizza
            {
                Name = "Pizza 3",
                Image = "pizza3img",
                Price = 1.45
            },
            new Pizza
            {
                Name = "Pizza 4",
                Image = "pizza4img",
                Price = 3.5
            },
            new Pizza
            {
                Name = "Pizza 5",
                Image = "pizza5img",
                Price = 2.99
            },
            new Pizza
            {
                Name = "Pizza 6",
                Image = "pizza6img",
                Price = 5.1
            },
            new Pizza
            {
                Name = "Pizza 7",
                Image = "pizza7img",
                Price = 4.0
            },
            new Pizza
            {
                Name = "Pizza 8",
                Image = "pizza8img",
                Price = 9.25
            },
            new Pizza
            {
                Name = "Pizza 9",
                Image = "pizza9img",
                Price = 3.24
            },
            new Pizza
            {
                Name = "Pizza 10",
                Image = "pizza10img",
                Price = 2.9
            }
        };

        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;

        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) =>
            _pizzas.OrderBy(p => Guid.NewGuid())
            .Take(count);

        public IEnumerable<Pizza> SearchPizzas(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }
}

