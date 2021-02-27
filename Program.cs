using System;
using System.IO;

namespace Uploads_de_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretórioRemetente = Directory.GetDirectories(Console.ReadLine()).ToString();           

            Console.WriteLine(diretórioRemetente);
        }
    }
}
