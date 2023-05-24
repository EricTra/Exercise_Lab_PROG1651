using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex
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
                case 7:
                    Problem7();
                    break;
            }
        }

        // Problem 1
        public static void Problem1()
        {
            List<CarPB1> cars = new List<CarPB1>();
            int numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                string st = Console.ReadLine();
                String[] listSt = st.Split();
                CarPB1 car = new CarPB1(listSt[0], int.Parse(listSt[1]), int.Parse(listSt[2]), int.Parse(listSt[3]), listSt[4],
                    double.Parse(listSt[5]), int.Parse(listSt[6]),
                    double.Parse(listSt[7]), int.Parse(listSt[8]),
                    double.Parse(listSt[9]), int.Parse(listSt[10]),
                    double.Parse(listSt[11]), int.Parse(listSt[12]));
                cars.Add(car);
            }

            string type = Console.ReadLine();

            foreach (var item in cars)
            {
                if (item.CargoType.Equals(type))
                {
                    switch (type)
                    {
                        case "fragile":
                            if (item.checkTire())
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "flamable":
                            if (item.EnginePower > 250)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                    }
                }
            }
        }

        // Problem 2;
        public static void Problem2()
        {
            List<EnginePB2> engines = new List<EnginePB2>();
            int numberOfEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngine; i++)
            {
                string s = Console.ReadLine();
                string[] st = s.Split();
                EnginePB2 engine = new EnginePB2();

                switch (st.Length)
                {
                    case 4:
                        engine = new EnginePB2(st[0], int.Parse(st[1]), st[2], st[3]);
                        break;
                    case 3:
                        int displacement;
                        if (int.TryParse(st[2], out displacement))
                        {
                            engine = new EnginePB2(st[0], int.Parse(st[1]), int.Parse(st[2]));
                        }
                        else
                        {
                            engine = new EnginePB2(st[0], int.Parse(st[1]), st[2]);
                        }
                        break;
                    case 2:
                        engine = new EnginePB2(st[0], int.Parse(st[1]));
                        break;
                }
                engines.Add(engine);

            }

            List<CarPB2> cars = new List<CarPB2>();
            int numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                string s = Console.ReadLine();
                string[] st = s.Split(" ");
                CarPB2 car = new CarPB2();
                EnginePB2 engineCar = findEngine(engines, st[1]);

                switch (st.Length)
                {
                    case 4:
                        car = new CarPB2(st[0], engineCar, st[2], st[3]);
                        break;
                    case 3:
                        int weight;
                        if (int.TryParse(st[2], out weight))
                        {

                            car = new CarPB2(st[0], engineCar, weight);
                        }
                        else
                        {

                            car = new CarPB2(st[0], engineCar, st[2]);
                        }
                        break;
                    case 2:
                        car = new CarPB2(st[0], engineCar);
                        break;
                }
                cars.Add(car);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        public static EnginePB2 findEngine(List<EnginePB2> engines, string engine)
        {
            foreach (var item in engines)
            {
                if (engine.Equals(item.Model))
                {
                    return item;
                }
            }
            return null;
        }

        // Problem 3;
        public static void Problem3()
        {
            string rowcolumn = Console.ReadLine();
            string[] rc = rowcolumn.Split();

            int row = int.Parse(rc[0]);
            int column = int.Parse(rc[1]);

            int[,] jedy = new int[row, column];
            int d = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    jedy[i, j] = d;
                    d++;
                }
            }

            string ivo = Console.ReadLine();
            string[] iv = ivo.Split();

            PositionPB3 ivoPosition = new PositionPB3(int.Parse(iv[0]), int.Parse(iv[1]));


            string evil = "";

            List<PositionPB3> evilPosition = new List<PositionPB3>();
            do
            {
                evil = Console.ReadLine();
                string[] ev = evil.Split();

                int evilX, evilY;
                if (int.TryParse(ev[0], out evilX) == true)
                {
                    evilY = int.Parse(ev[1]);
                    PositionPB3 evlPosition = new PositionPB3(evilX, evilY);

                    evilPosition.Add(evlPosition);

                }
            } while (evil.Equals("Let the fore be with you") == false);





            for (int i = 0; i < column; i++)
            {
                foreach (var item in evilPosition)
                {
                    if (item.X < row && item.Y < column && item.X >= 0 && item.Y >= 0)
                    {

                        jedy[item.X, item.Y] = 0;
                    }
                    item.X--;
                    item.Y--;
                }
            }

            int sum = 0;
            do
            {

                if (ivoPosition.X <= row && ivoPosition.Y >= 0 && ivoPosition.X >= 0 && ivoPosition.Y < column)
                {
                    sum = sum + jedy[ivoPosition.X, ivoPosition.Y];
                }

                ivoPosition.X--;
                ivoPosition.Y++;
            } while (ivoPosition.X >= 0);

            Console.WriteLine(sum);
        }

        // Problem 4;
        public static void Problem4()
        {
            List<DepartmenPB4> listDepartment = new List<DepartmenPB4>();
            string st = Console.ReadLine();
            do
            {
                string[] s = st.Split();
                string nameDP = s[0];
                string nameDoctor = s[1] + " " + s[2];
                string namePatient = s[3];
                bool check = true;
                foreach (var item in listDepartment)
                {
                    if (item.Name.Equals(nameDP))
                    {
                        item.addPatientToDepartment(new PatientPB4(namePatient, nameDoctor));
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    listDepartment.Add(new DepartmenPB4(nameDP));
                    listDepartment[listDepartment.Count - 1].addPatientToDepartment(new PatientPB4(namePatient, nameDoctor));
                }
                st = Console.ReadLine();

            } while (st.Equals("Output") == false);
            st = Console.ReadLine();
            Console.ReadLine();
            string[] ss = st.Split();
            if (ss.Length == 1)
            {
                foreach (var department in listDepartment)
                {
                    if (department.Name.Equals(ss[0]))
                    {
                        department.displayPatientDepartment();
                    }
                }
            }
            else
            {
                int room = 0;
                if (int.TryParse(ss[1], out room))
                {
                    foreach (var department in listDepartment)
                    {
                        if (department.Name.Equals(ss[0]))
                        {
                            department.displayPatientRoom(room);
                        }
                    }
                }
                else
                {
                    string nameDoctor = ss[0] + " " + ss[1];
                    nameDoctor = nameDoctor.Trim();
                    List<PatientPB4> listPatientDoctor = new List<PatientPB4>();
                    foreach (var department in listDepartment)
                    {
                        listPatientDoctor = department.displayPatientDoctor(listPatientDoctor, nameDoctor);
                    }
                    listPatientDoctor.Sort((x, y) => string.Compare(x.Name, y.Name));
                    foreach (var item in listPatientDoctor)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }

        }

        // Problem 5;
        public static void Problem5()
        {

            int quantity = int.Parse(Console.ReadLine());

            string st = Console.ReadLine();
            st = st.ToUpper();
            st = st.Trim();
            List<TreasurePB5> treasureGoldList = new List<TreasurePB5>();
            List<TreasurePB5> treasureGemList = new List<TreasurePB5>();
            List<TreasurePB5> treasureCashList = new List<TreasurePB5>();

            do
            {
                string type = "";
                for (int i = 0; i < st.Length; i++)
                {
                    type = type + st[i];
                    if (i == st.Length - 1)
                    {
                        break;
                    }
                    else
                     if (char.IsDigit(st[i]) && st[i + 1] == ' ')
                    {
                        break;
                    }
                }
                if (type.Length == st.Length)
                {
                    st = st.Remove(0, type.Length);
                }
                else
                {
                    st = st.Remove(0, type.Length + 1);
                }
                string[] typed = type.Split();

                TreasurePB5 treasure;
                if (typed[0].Equals("GOLD"))
                {
                    treasure = new TreasurePB5("Gold", "Gold", int.Parse(typed[1]));
                    treasureGoldList.Add(treasure);
                }
                else
                    if (typed[0].Contains("GEM"))
                {
                    bool kt = true;
                    foreach (var item in treasureGemList)
                    {
                        if (toLower(typed[0]).Equals(item.Type))
                        {
                            kt = false;
                            item.Quantity = item.Quantity + int.Parse(typed[1]);
                        }
                    }
                    if (kt == true)
                    {
                        treasure = new TreasurePB5("Gem", toLower(typed[0]), int.Parse(typed[1]));
                        treasureGemList.Add(treasure);
                    }

                }
                else
                {
                    bool kt = true;
                    foreach (var item in treasureCashList)
                    {
                        if (typed[0].Equals(item.Type))
                        {
                            kt = false;
                            item.Quantity = item.Quantity + int.Parse(typed[1]);
                        }
                    }
                    if (kt == true)
                    {
                        treasure = new TreasurePB5("Cash", typed[0], int.Parse(typed[1]));
                        treasureCashList.Add(treasure);
                    }
                }


            } while (st.Length > 0);

            treasureGoldList.Sort((x, y) => y.Quantity.CompareTo(x.Quantity));
            treasureGemList.Sort((x, y) => y.Quantity.CompareTo(x.Quantity));
            treasureCashList.Sort((x, y) => y.Quantity.CompareTo(x.Quantity));

            TreasurePB5 treasureGoldBag = new TreasurePB5("Gold", "Gold", 0);
            int totalGold = 0;
            foreach (var item in treasureGoldList)
            {
                if (item.Type.Equals("Gold"))
                {
                    if (totalGold + item.Quantity <= quantity)
                    {
                        totalGold = totalGold + item.Quantity;
                        treasureGoldBag.Quantity = totalGold;
                    }
                }
            }


            List<TreasurePB5> treasureGemListBag = new List<TreasurePB5>();
            int totalGem = 0;
            foreach (var item in treasureGemList)
            {
                if (item.Type.Equals("Gem"))
                {
                    if ((totalGem + item.Quantity + totalGold <= quantity) && (totalGem + item.Quantity <= totalGold))
                    {
                        totalGem = totalGem + item.Quantity;
                        treasureGemListBag.Add(item);
                    }
                }
            }


            List<TreasurePB5> treasureCashListBag = new List<TreasurePB5>();
            int totalCash = 0;
            foreach (var item in treasureCashList)
            {
                if (item.Type.Equals("Cash"))
                {
                    if ((totalCash + item.Quantity + totalGem + totalGold <= quantity) && (totalCash + item.Quantity <= totalGem))
                    {
                        totalCash = totalCash + item.Quantity;
                        treasureCashListBag.Add(item);
                    }
                }
            }

            Console.WriteLine($"<Gold> ${totalGold}");
            Console.WriteLine(treasureGoldBag);

            Console.WriteLine($"<Gem> ${totalGem}");
            treasureGemListBag.Sort();
            foreach (var item in treasureGemListBag)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"<Cash> ${totalCash}");
            treasureCashListBag.Sort();
            foreach (var item in treasureCashListBag)
            {
                Console.WriteLine(item);
            }
        }
        public static string toLower(string st)
        {
            st = st.ToLower();
            st = char.ToUpper(st[0]) + st.Substring(1);
            return st;
        }
        // Problem 6;
        public static void Problem6()
        {
            int numberOfRow = int.Parse(Console.ReadLine());


            string st = Console.ReadLine();
            int numberOfColumn = st.Length;
            char[,] matrix = new char[numberOfRow, numberOfColumn];
            PositionPB6 samPoint = new PositionPB6(0, 0);
            PositionPB6 nikoPoint = new PositionPB6(0, 0);

            for (int i = 0; i < numberOfRow; i++)
            {
                for (int j = 0; j < numberOfColumn; j++)
                {
                    matrix[i, j] = st[j];
                    if (st[j] == 'S')
                    {
                        samPoint.X = i;
                        samPoint.Y = j;
                    }
                    if (st[j] == 'N')
                    {
                        nikoPoint.X = i;
                        nikoPoint.Y = j;
                    }
                }
                st = Console.ReadLine();
            }

            string command = st;
            bool isDead = false;
            for (int i = 0; i < command.Length; i++)
            {
                if (isDead == false)
                {
                    for (int x = 0; x < numberOfRow; x++)
                    {
                        for (int y = 0; y < numberOfColumn; y++)
                        {

                            if (matrix[x, y] == 'b')
                            {

                                if (y == numberOfColumn - 1) matrix[x, y] = 'd';
                                else
                                {
                                    matrix[x, y] = '.';
                                    matrix[x, y + 1] = 'b';
                                }
                                break;
                            }
                            else if (matrix[x, y] == 'd')
                            {
                                if (y == 0) matrix[x, y] = 'b';
                                else
                                {
                                    matrix[x, y] = '.';
                                    matrix[x, y - 1] = 'd';
                                }
                                break;
                            }
                        }

                    }
                }
                Console.WriteLine(command[i]);
                move(matrix, numberOfRow, numberOfColumn);
                Console.WriteLine();
                for (int j = 0; j < numberOfColumn; j++)
                {
                    if (matrix[samPoint.X, j] == 'b')
                    {
                        if (j < samPoint.Y)
                        {
                            matrix[samPoint.X, samPoint.Y] = 'X';

                            isDead = true;
                        }
                    }
                    else
                        if (matrix[samPoint.X, j] == 'd')
                    {
                        if (j > samPoint.Y)
                        {
                            matrix[samPoint.X, samPoint.Y] = 'X';

                            isDead = true;
                        }
                    }
                }
                // Console.WriteLine(command[i]);
                // move(matrix,numberOfRow,numberOfColumn);

                if (isDead == false && (samPoint.X != nikoPoint.X))
                {

                    switch (command[i])
                    {
                        case 'U':
                            matrix[samPoint.X, samPoint.Y] = '.';
                            samPoint.X--;
                            matrix[samPoint.X, samPoint.Y] = 'S';
                            break;
                        case 'D':
                            matrix[samPoint.X, samPoint.Y] = '.';
                            samPoint.X++;
                            matrix[samPoint.X, samPoint.Y] = 'S';
                            break;
                        case 'L':
                            matrix[samPoint.X, samPoint.Y] = '.';
                            samPoint.Y--;
                            matrix[samPoint.X, samPoint.Y] = 'S';
                            break;
                        case 'R':
                            matrix[samPoint.X, samPoint.Y] = '.';
                            samPoint.Y++;
                            matrix[samPoint.X, samPoint.Y] = 'S';
                            break;
                    }
                }
                else break;

            }

            if (isDead)
            {
                Console.WriteLine($"Sam died at {samPoint.X}, {samPoint.Y}");
                move(matrix, numberOfRow, numberOfColumn);
            }
            else
            {
                Console.WriteLine("Nikoladze killed!");
                matrix[nikoPoint.X, nikoPoint.Y] = 'X';
                move(matrix, numberOfRow, numberOfColumn);
            }
        }
        public static void move(char[,] matrix, int numX, int numY)
        {
            for (int i = 0; i < numX; i++)
            {
                for (int j = 0; j < numY; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        // Problem 7;
        public static void Problem7()
        {
            PersonPB7 victim = new PersonPB7("", "");
            string st = Console.ReadLine();

            if (st.Any(c => Char.IsDigit(c)))
            {
                victim.Age = st;
            }
            else victim.Name = st;
            List<string> relation = new List<string>();
            List<PersonPB7> persons = new List<PersonPB7>();
            st = Console.ReadLine();
            do
            {
                if (st.Contains('-'))
                {
                    relation.Add(st);
                }
                else
                {
                    string[] s = st.Split();
                    string name = "";
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        name = name + " " + s[i];
                    }
                    name = name.Trim();
                    if (name.Equals(victim.Name))
                    {
                        victim.Age = s[s.Length - 1];
                    }
                    else if (s[s.Length - 1].Equals(victim.Age))
                    {
                        victim.Name = name;
                    }
                    persons.Add(new PersonPB7(name, s[s.Length - 1]));
                }
                st = Console.ReadLine();

            } while (st.Equals("End") == false);

            Console.WriteLine();
            Console.WriteLine($"{victim.Name} {victim.Age}");
            Console.WriteLine("Parents:");
            foreach (var item in relation)
            {
                string[] s = item.Split('-');
                string first = s[0].Trim();
                string second = s[1].Trim();

                if (second.Equals(victim.Name) || second.Equals(victim.Age))
                {
                    foreach (var person in persons)
                    {
                        if (first.Equals(person.Name) || first.Equals(person.Age))
                        {
                            Console.Write($"{person.Name} {person.Age}");
                            Console.WriteLine();
                            break;
                        }
                    }

                }
            }
            Console.WriteLine("Childrens:");
            foreach (var item in relation)
            {
                string[] s = item.Split('-');
                string first = s[0].Trim();
                string second = s[1].Trim();

                if (first.Equals(victim.Name) || first.Equals(victim.Age))
                {
                    foreach (var person in persons)
                    {
                        if (second.Equals(person.Name) || second.Equals(person.Age))
                        {
                            Console.Write($"{person.Name} {person.Age}");
                            break;
                        }
                    }

                }
            }
        }
    }
}