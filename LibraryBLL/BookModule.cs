using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    public class BookModule : IPublication
    {
        string _path = @"C:\Users\Elbek\Desktop\LibraryApp\LibraryDAL\LibraryAppStorage.txt";
        public int Id { get ; set ; }
        public string Title { get ; set ; }
        public string Author { get; set ; }
        public List<string> Lines { get; set; } = new List<string>();

        public BookModule()
        {
            Id = new Random().Next(1, 1000);
            Title = "Not defined title";
            Author = "Not defined author";
        }
        public BookModule(int _id, string _title, string _author)
        {
            Id = _id;
            Title = _title;
            Author = _author;
        }
        public override string ToString()
        {
            return $"ID: {Id} | Title: {Title} | Author: {Author}";
        }
        public void Create(int id, string title, string author)
        {
            string stringToAppend = new BookModule(id, title, author).ToString();
            File.AppendAllText(_path, stringToAppend);
        }

        public void Present()
        {
            // Open the file to read from.
            string[] readText = File.ReadAllLines(_path, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }
    }
}
