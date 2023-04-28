namespace PizzaRestaurant.Models
{
    public class Pizza
    {
        public string Name { get; set; }

        public Dough Dough { get; set; }

        public ICollection<Topping> Toppings { get; set; }
    }
}
