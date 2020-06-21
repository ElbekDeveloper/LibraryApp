using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    public static class User
    {
        private static void ReadFromFile()
        {
            string _path = @"C:\Users\Elbek\Desktop\LibraryApp\LibraryDAL\LibraryAppStorage.txt";
            // Open the file to read from.
            string[] readText = File.ReadAllLines(_path, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }
        public static void GiveOptions()
        {
            Console.WriteLine("WELCOME TO DIGITAL LIBRARY");
            Console.WriteLine("1. Read data from text file\n2. Add new book\n");
            Console.Write("Please choose one menu item: ");
            string option = Console.ReadLine();
            Console.Clear();

            switch (option.Trim())
            {
                case "1":
                    ReadFromFile();
                    break;
                case "2":
                    GetBookData();
                    break;
                default:
                    Console.WriteLine("Please, enter correct number!");
                    break;
            }

        }

        private static void GetBookData()
        {
            int id = (new Random()).Next(1, 1000);
            string title;
            string author;
            Console.Write("Please, enter book Id: ");

            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.Write("Please, enter book title: ");
            try
            {
                title = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;

            }
            Console.Write("Please, enter book author: ");
            try
            {
                author = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;

            }
            IPublication _ = new BookModule();
            _.Create(id, title, author);
        }
        
    }
}
