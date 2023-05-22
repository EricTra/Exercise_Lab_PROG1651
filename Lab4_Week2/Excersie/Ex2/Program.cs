using Ex2;
namespace Ex2
{
    class Test
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the author:");
                string author = Console.ReadLine();

                Console.WriteLine("Enter the title:");
                string title = Console.ReadLine();

                Console.WriteLine("Enter the price:");
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}