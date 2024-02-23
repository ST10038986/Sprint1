using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1_EpicBookstoreApplication.Models
{
    public class Cart
    {
        [Key]
        public int ShoppingCartID { get; set; }

        public List<Inventory> Inventory { get; set; } = new List<Inventory>();
       
    }
}
