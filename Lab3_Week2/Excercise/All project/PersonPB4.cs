using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_project
{
    internal class PersonPB4
    {
        private string name;
        private int money;
        private List<ProductPB4> bagOfProducts = new List<ProductPB4>();

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException("Name cannot be empty");
                else name = value;
            }
        }
        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");
                else money = value;
            }
        }

        public IReadOnlyCollection<ProductPB4> BagOfProducts { get { return bagOfProducts.AsReadOnly(); } }

        public PersonPB4(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void AddProductToBag(ProductPB4 product) => bagOfProducts.Add(product);

        public void DisplayProductInBag()
        {
            Console.Write($"{Name} - ");
            foreach (var product in bagOfProducts)
            {
                if (product != bagOfProducts[bagOfProducts.Count - 1]) Console.Write($"{product.Name}, ");
                else Console.Write($"{product.Name}");
            }
        }
    }
}
