using All_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your Exercises: ");
            int choosen = int.Parse(Console.ReadLine());
            switch (choosen)
            {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    Problem3();
                    break;
                case 4:
                    Problem4();
                    break;
                case 5:
                    Problem5();
                    break;
                case 6:
                    Problem6();
                    break;

            }
        }

        // Problem 1
        public static void Problem1()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Boxs box = new Boxs(length, width, height);

            Console.WriteLine($"Surface Area – {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");

        }

        // Problem 2
        public static void Problem2()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Boxs box = new Boxs(length, width, height);
            Console.WriteLine($"Surface Area – {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }

        // Problem 3
        public static void Problem3()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Chicken chicken = new Chicken(name, age);
                chicken.ProductPerDay();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Problem 4
        public static void Problem4()
        {
            List<PersonPB4> listPerson = new List<PersonPB4>();
            string st = Console.ReadLine();
            string s = "";
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ';' || i == st.Length - 1)
                {
                    if (i == st.Length - 1) s = s + st[i];
                    string[] t = s.Split('=');
                    listPerson.Add(new PersonPB4(t[0], int.Parse(t[1])));
                    s = "";
                }
                else s = s + st[i];
            }

            List<ProductPB4> listProduct = new List<ProductPB4>();
            st = Console.ReadLine();
            s = "";
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ';')
                {
                    string[] t = s.Split('=');
                    listProduct.Add(new ProductPB4(t[0], int.Parse(t[1])));
                    s = "";
                }
                else s = s + st[i];
            }

            List<string> stringList = new List<string>();
            st = Console.ReadLine();
            do
            {
                stringList.Add(st.Trim());
                st = Console.ReadLine();

            } while (st.Equals("END") == false);


            for (int i = 0; i < stringList.Count; i++)
            {
                StringBuilder stt = new StringBuilder(stringList[i]);
                for (int j = 0; j < stt.Length; j++)
                {
                    if (stt[j] == ' ')
                    {
                        stt[j] = ';';
                    }
                }
                stringList[i] = stt.ToString();

            }


            Console.WriteLine();
            foreach (var sst in stringList)
            {
                string d = sst.Trim();

                List<string> sdt = d.Split(';').ToList();
                Console.WriteLine(sdt[0], " ", sdt[1]);
                foreach (var person in listPerson)
                {
                    if (sdt[0].Equals(person.Name))
                    {
                        foreach (var product in listProduct)
                        {
                            if (sdt[1].Equals(product.Name))
                            {
                                //Console.WriteLine($"{person.Name} {person.Money} {product.Name} {product.Cost}");
                                if (person.Money - product.Cost >= 0)
                                {
                                    person.Money = person.Money - product.Cost;
                                    person.AddProductToBag(product);
                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                }
                                break;
                            }

                        }
                    }
                    break;

                }
            }

            foreach (var person in listPerson)
            {
                person.DisplayProductInBag();
                Console.WriteLine();
            }
        }

        // Problem 5
        public static void Problem5()
        {

        }

        // Problem 6
        public static void Problem6()
        {

        }
    }
}