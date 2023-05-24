using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class TreasurePB5 : IComparable<TreasurePB5>
    {
        private string type;
        private string name;
        private int quantity;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public TreasurePB5(string type, string name, int quantity)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return $"##{name} - {quantity}";
        }

        public int CompareTo(TreasurePB5 other)
        {
            if (Type != other.Type)
                return string.Compare(Type, other.Type);

            int nameComparison = string.Compare(other.Name, Name);
            if (nameComparison != 0)
                return nameComparison;

            return Quantity.CompareTo(other.Quantity);
        }
    }
}