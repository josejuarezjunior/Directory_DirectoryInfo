using System;
using System.IO;
namespace Course

/*
* Objetivos:
* Vamos listar as pastas a partir de uma pasta informada.
* Vamos listar os arquivos a partir de uma pasta informada.
* Vamos criar uma pasta.
*/

{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            try
            {
                /*Aqui é utilizado "var" como tipo, porém o C# sabe que se trata de um tipo "IEnumerable".
                * Outra forma de declarar seria: "IEnumerate<string> folders = ...".
                * Para fazer dessa forma, deve-se usar a biblioteca "using System.Collections.Generic;".
                */

                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                //Semelhante ao exemplo acima, sobre "IEnumerable".
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(path + @"\newfolder");
                /* Ou:
                * Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
                * Ou:
                * Directory.CreateDirectory(path + "\\newfolder");
                */
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}