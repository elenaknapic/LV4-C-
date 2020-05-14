using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Z2
            //Dataset dataset = new Dataset(@"C:\Users\Elena\Source\Repos\lv4\lv4\bin\Debug\LV3.cvs");
            //Analyzer3rdParty party = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(party);
            //double[] rowAverage = adapter.CalculateAveragePerRow(dataset);
            //double[] columnAverage = adapter.CalculateAveragePerColumn(dataset);

            //for (int i = 0; i < rowAverage.Length; i++)
            //{
            //    Console.Write(rowAverage[i] + " ");
            //}
            //Console.WriteLine();

            //for (int j = 0; j < columnAverage.Length; j++)
            //{
            //    Console.Write(columnAverage[j] + " ");
            //}
            //Console.WriteLine("\n");


            //Z3
            List<IRentable> rentable = new List<IRentable>();
            Book book = new Book("Crime and Punishment");
            rentable.Add(book);
            Movie video = new Movie("The Incredibles");
            rentable.Add(video);
            RentingConsolePrinter rent = new RentingConsolePrinter();
            rent.PrintTotalPrice(rentable);
            rent.DisplayItems(rentable);
            Console.WriteLine("\n");


            //Z4
            Book book2 = new Book("Anna Karenina");
            Movie video2 = new Movie("Avengers:Endgame");
            HotItem hotItem = new HotItem(book2);
            rentable.Add(hotItem);
            HotItem hotItem2 = new HotItem(video2);
            rentable.Add(hotItem2);
            rent.PrintTotalPrice(rentable);
            rent.DisplayItems(rentable);
            Console.WriteLine("\n");






        }
    }
}
