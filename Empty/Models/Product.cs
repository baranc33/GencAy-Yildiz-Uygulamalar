using Empty.Models.Validasyon;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Empty.Models
{

    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = "";
        public decimal Quantity { get; set; }
    }
}
