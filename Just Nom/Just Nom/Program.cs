using System.Runtime.InteropServices;

namespace Just_Nom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select a file");

            string filepath = "../../../../";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.txt"))
            {
                Console.WriteLine(file.ToString());
            }
        }
    }
}