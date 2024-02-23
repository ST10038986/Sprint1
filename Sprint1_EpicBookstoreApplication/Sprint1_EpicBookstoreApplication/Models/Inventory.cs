using System.ComponentModel.DataAnnotations;

namespace Sprint1_EpicBookstoreApplication.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int ISBN { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

    }
}

