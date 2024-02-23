namespace Sprint1_EpicBookstoreApplication.Models
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public interface ICartService
    {
        void AddItemToCart(Inventory item);
        List<CartViewModel> GetCartItem();
    }
}
