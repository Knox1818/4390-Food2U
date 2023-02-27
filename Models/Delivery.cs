using System.ComponentModel.DataAnnotations;

namespace Final_Project_CarBag.Models
{
    public class Delivery{
        public int DeliveryID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Driver {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? CustomerAddress {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? DeliveryTime {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
    }
}