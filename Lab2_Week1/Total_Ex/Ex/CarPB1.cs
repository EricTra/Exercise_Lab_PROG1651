using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class CarPB1
    {
        private string model;
        private int engineSpeed;
        private int enginePower;
        private int cargoWeight;
        private string cargoType;
        private double tire1Pressure;
        private int tire1Age;
        private double tire2Pressure;
        private int tire2Age;
        private double tire3Pressure;
        private int tire3Age;
        private double tire4Pressure;
        private int tire4Age;

        public CarPB1(string model, int engineSpeed, int enginePower, int cargoWeight,
            string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure,
            int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
            this.tire1Pressure = tire1Pressure;
            this.tire1Age = tire1Age;
            this.tire2Pressure = tire2Pressure;
            this.tire2Age = tire2Age;
            this.tire3Pressure = tire3Pressure;
            this.tire3Age = tire3Age;
            this.tire4Pressure = tire4Pressure;
            this.tire4Age = tire4Age;
        }

        public string CargoType { get { return cargoType; } }

        public int EnginePower { get { return enginePower; } }
        public bool checkTire()
        {
            if (tire1Pressure < 1 || tire2Pressure < 1 || tire3Pressure < 1 || tire4Pressure < 1)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{this.model}";
        }
    }
}
