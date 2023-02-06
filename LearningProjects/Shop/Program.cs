using System;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ShowProducts();

            List<Product> products2 = new List<Product>();

            for (int i = 0; i < cart.GetProductsCount(); i++)
            {
                products2.Add(cart.GetProductByIndex(i));
            }

            products2.RemoveAt(0);

            Console.WriteLine();
            cart.ShowProducts();
            Console.WriteLine();

            foreach (var product in products2)
            {
                Console.WriteLine(product.Name);
            }
        }
    }

    class Cart
    {
        private List<Product> products = new List<Product>();

        public Cart()
        {
            products.Add(new Product("Яблоко"));
            products.Add(new Product("Банан"));
            products.Add(new Product("Апельсин"));
            products.Add(new Product("Груша"));
        }

        public void ShowProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public Product GetProductByIndex(int index)
        {
            return products.ElementAt(index);
        }

        public int GetProductsCount()
        {
            return products.Count;
        }
    }

    class Product
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}