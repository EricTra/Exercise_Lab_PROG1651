using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class EnginePB2
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;


        public EnginePB2()
        {
        }

        public EnginePB2(string model, int power, string displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public EnginePB2(string model, int power, int displacement)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement.ToString();
            this.efficiency = "n/a";
        }

        public EnginePB2(string model, int power, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.efficiency = efficiency;
            this.displacement = "n/a";
        }

        public EnginePB2(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.efficiency = "n/a";
            this.displacement = "n/a";
        }

        public string Model { get { return model; } set { model = value; } }

        public override string ToString()
        {
            return $" {this.model}:\n  Power: {this.power}\n  Displacement: {this.displacement}\n  Efficiency:{this.efficiency}";
        }
    }
}