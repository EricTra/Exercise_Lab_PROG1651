using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_project
{
    internal class ProductPB4
    {
        private string name;
        private int cost;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException("Name cannot be empty");
                else name = value;
            }
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                if (cost < 0) throw new ArgumentException("Money cannot be negative");
                else cost = value;
            }
        }

        public ProductPB4(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
