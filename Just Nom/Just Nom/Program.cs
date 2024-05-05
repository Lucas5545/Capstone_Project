using System.Runtime.InteropServices;

namespace Just_Nom
{
    internal class Program
    {
        static decimal price = 0.00m; 
        static List<string> files = new List<string>(); 
        static void Main(string[] args)
        {
            try 
            {
                CreateFileList("../../../../");
                while (!SelectedFile());
                ConfirmFileSelection();
            } 
            catch(Exception m) 
            {
                Console.WriteLine(m.Message);
            }

        }
        private static void CreateFileList(string filepath) 
        {
            DirectoryInfo d = new DirectoryInfo(filepath);
            foreach (var file in d.GetFiles("*.txt"))
            {
                files.Add(file.FullName);
            }

        }
        private static bool SelectedFile() 
        {
            Console.WriteLine("select a file");
            for (int i = 0; i < files.Count; i++) 
            {
                Console.WriteLine($"{i + 1}, {files[i]}");
            }

            Console.WriteLine($"\nplease enter a number between 1 and {files.Count}");

            bool isNumber = int.TryParse(Console.ReadLine(), out int selction);
            if (selction > files.Count || selction < 0 || ! isNumber ) 
            {
                Console.WriteLine("\nunable to load file");
                return false;
            }

            return true;
            Console.WriteLine();

        }
        private static void ConfirmFileSelection() 
        {
            Console.WriteLine("\nselect a number between 1 and 2");
            Console.WriteLine("1. Place new order");
            Console.WriteLine("2. Exit");
            string selection = Console.ReadLine();
            if (selection == "1" ) 
            {
                

            }
            else if (selection == "2") { Environment.Exit(0); }
            else 
            { 
                Console.WriteLine($"the given input is not allowed");
                ConfirmFileSelection();
            }
        }
        private static bool IsDelivery() 
        {
            Console.WriteLine("please eneter a customer name");
            string name = Console.ReadLine();
            Console.WriteLine("is this a delivery?");
            Console.WriteLine("Enter Y for yes or N for no");
            string selection = Console.ReadLine().ToLower();
            if (selection == "y")
            {
                price += 2m;
                return true;
            }
            else if (selection == "n") 
            {
                return false;
            }
            else
            {
                IsDelivery();
            }
            return false;
        } 
        private static void TotalPrice(string name) 
        {
            Console.WriteLine($"order for {name}");
            Console.WriteLine($"total cost £{price}");
        }
        private static void DispayContentOfFile(string filepath) 
        {
            if (!File.Exists(filepath)) 
            {
                throw new Exception("file doesnt exist");
            }

            StreamReader sr = new StreamReader(filepath);
            while ( !sr.EndOfStream ) 
            {
                
            }
        }
    }
}