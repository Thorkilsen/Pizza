using System;
namespace Big_mommas_pizza
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public decimal TotalPrice { get; private set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }   

        public decimal CalculateTotalPrice()
        {
            TotalPrice = 40; // Starting with delivery cost
            foreach (Pizza pizza in Pizzas)
            {
                TotalPrice += pizza.Price;
                foreach (Topping topping in pizza.Toppings)
                {
                    TotalPrice += topping.Price;
                }
            }
            return TotalPrice;
        }

        public override string ToString()
        {
            List<string> pizzaNames = new List<string>();
            foreach (Pizza pizza in Pizzas)
            {
                pizzaNames.Add(pizza.Name);
            }
            string pizzasAsString = string.Join(", ", pizzaNames);
            return $"Order for {Customer.Name}, Address: {Customer.Address}: Pizzas: {pizzasAsString}, Total Price = {CalculateTotalPrice()} DKK";
        }
    }

}


