using System;
using System.IO;

namespace Uploads_de_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pastaOrigem = Console.ReadLine();
                 
                Directory.Move
                (
                    pastaOrigem,
                    "C:\\Users\\guilh\\OneDrive\\Documentos\\Destinatario"
                );

               
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
            

                      

            
        }
    }
}
