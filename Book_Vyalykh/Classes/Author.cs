using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Vyalykh.Classes
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public static List<Author> AllAuthor()
        {
            List<Author> allAuthors = new List<Author>();
            allAuthors.Add(new Author(1, "Виктор Пелевин"));
            allAuthors.Add(new Author(2, "Александра Маринина"));
            allAuthors.Add(new Author(3, "Ольга Герр"));
            return allAuthors;
        }
    }
}
