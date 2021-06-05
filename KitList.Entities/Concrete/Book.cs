using KitList.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KitList.Entities.Concrete
{
   public class Book : IEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]        
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [MaxLength(4)]
        [Display(Name = "Publish Year")]
        public string PublishYear { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
