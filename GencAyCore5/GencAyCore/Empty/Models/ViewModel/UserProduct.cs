namespace Empty.Models.ViewModel
{
    public class UserProduct
    {
        public User User { get; set; } = new();
        public Product Product { get; set; } = new();
    }
}
