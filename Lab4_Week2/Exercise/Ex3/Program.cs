using System;
namespace Ex3
{
    class Program
    {
        static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split(' ');
                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                string facultyNumber = studentInfo
    [2];

                Student student = new Student(studentFirstName, studentLastName, facultyNumber);

                string[] workerInfo = Console.ReadLine().Split(' ');
                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal workHoursPerDay = decimal.Parse(workerInfo[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
