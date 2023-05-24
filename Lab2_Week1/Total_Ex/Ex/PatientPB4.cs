using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class PatientPB4
    {
        private string name;
        private string doctor;

        public string Name { get { return name; } set { name = value; } }
        public string Doctor { get { return doctor; } set { doctor = value; } }

        public PatientPB4(string name, string doctor)
        {
            this.name = name;
            this.doctor = doctor;
        }
    }
}