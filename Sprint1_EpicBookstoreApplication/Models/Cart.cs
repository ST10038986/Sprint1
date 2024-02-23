using System.ComponentModel.DataAnnotations;

namespace Sprint1_EpicBookstoreApplication.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public List<Inventory> Inventories { get; set; } = new List<Inventory>();
    }


}
