using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    public interface IPublication
    {
        /// <summary>
        /// Represents the unique identifier of the instance
        /// </summary>
       int Id { get; set; }
        /// <summary>
        /// Represents the title of the publication
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// Represents the author of the publication
        /// </summary>
        string Author { get; set; }
        /// <summary>
        /// Creates the book instances to store in the file
        /// </summary>
        /// <param name="_id">Id of the publication</param>
        /// <param name="_title">title of the publication</param>
        /// <param name="_author">author of the publication</param>
        void Create(int id, string title, string author);
        /// <summary>
        /// Presents to the user
        /// </summary>
        void Present();
    }
}
