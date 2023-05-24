using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class CarPB2
    {
        private string model;
        private EnginePB2 engine;
        private string weight;
        private string color;


        public EnginePB2 Engine { get { return engine; } set { engine = value; } }

        public CarPB2()
        {
        }

        public CarPB2(string model, EnginePB2 engine, string weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public CarPB2(string model, EnginePB2 engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight.ToString();
            this.color = "n/a";
        }

        public CarPB2(string model, EnginePB2 engine, string color)
        {
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.weight = "n/a";
        }

        public CarPB2(string model, EnginePB2 engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = "n/a";
            this.color = "n/a";
        }

        public override string ToString()
        {
            return $"{this.model}:\n{this.engine}\n Weight: {this.weight}\n Color: {this.color}";
        }
    }
}