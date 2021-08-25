using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chungventory.Models
{
    public class InventoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ItemPictureFileName { get; set; }
    }
}