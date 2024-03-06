	using System;
namespace Big_mommas_pizza
{
	public class Pizza
	{
		
	
         public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Topping> Toppings { get; set; }

        public Pizza(string name, decimal price)
        {
            Name = name;
            Price = price;
            Toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} (${Price})";
        }
    }



}

	


