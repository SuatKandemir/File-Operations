using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementApplication
{
    public class FileManagement
    {
    }
    public class FileManagements
    {


          public static void CreateFile()
        {

            Console.WriteLine("Please enter the file name you want to create");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
                Console.WriteLine($"{filename} Your file has been created ");
            }
            else
            {
                Console.WriteLine($"{filename}: Named file has already been created before");
            }
        }
         public static void FileReading()
        {
            Console.WriteLine("Please enter the name of the file you want to read");
            string filesname = Console.ReadLine();
            if (File.Exists(filesname))
            {
                string content = File.ReadAllText(filesname);
                Console.WriteLine($"Dosya içeriği \n {content}");
            }
            else
            {
                Console.WriteLine($"{filesname} Your forensic file was not found");
            }
        }

        public static void FileWriting()
        {
            Console.WriteLine("Please enter the name of the file you want to print");
            string filname = Console.ReadLine();

            Console.WriteLine("Enter the text you want to write to the file");
            string content = Console.ReadLine();

            File.WriteAllText(filname, content);
            Console.WriteLine($"{filname} to the file named file.");
        }

        public static void FileDelete()
        {
            Console.WriteLine("Please enter the name of the file you want to delete");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                Console.WriteLine($"{filename} the file is removed");
            }
            else
            {
                Console.WriteLine($" {filename} no such file found");
            }

        }

    }
}