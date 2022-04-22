using System.ComponentModel.DataAnnotations;

namespace Empty.Models.Validasyon
{
    public class ProductMetadata
    {

        [Required(ErrorMessage = "Boş geliçelemez")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir")]
        public string ProductName { get; set; } = "";
    }
}
