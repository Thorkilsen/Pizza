using System;
namespace Big_mommas_pizza
{
    public class Store
    {
        public void Start()
        {
            // Create pizzas
            Pizza margherita = new Pizza("Margherita", 60);
            Pizza pepperoni = new Pizza("Pepperoni", 70);
            Pizza hawaiian = new Pizza("Hawaiian", 65);

            // Create toppings
            Topping cheese = new Topping("Extra Cheese", 10);
            Topping mushrooms = new Topping("Mushrooms", 5);

            // Adding toppings to pizzas
            margherita.AddTopping(cheese);
            pepperoni.AddTopping(mushrooms);

            // Create customers
            Customer Henrik = new Customer("Henrik", "Mosevej 81");
            Customer Thomas = new Customer("Thomas", "Byskov alle 2 st, tv");
            Customer Ida = new Customer(   "Ida",    "Idagårdsvej 27");

            // Create orders
            Order order1 = new Order(Henrik);
            order1.AddPizza(margherita);

            Order order2 = new Order(Thomas);
            order2.AddPizza(pepperoni);

            Order order3 = new Order(Ida);
            order3.AddPizza(hawaiian);

            // Print out order information
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
        }
    }


}

