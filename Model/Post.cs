using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace WebApplication2.Model
{
    public class Post
    {
        [ScaffoldColumn(false)]
        public int PostId { get; set; }
        [Required]
        public int? CategoryId { get; set;  }
        public virtual Category Category{ get; set; }
        [Required]
        public int? StateId { get; set; }
        public virtual State State { get; set; }
  
        public virtual List<PostAttributes> Attributes { get; set; }
        [Required]
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        [Required]
        public virtual ApplicationUser CreatedBy { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public string Price { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }
        [DataType(DataType.ImageUrl)]
        [Required]
        public string Image { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public bool Is_Active { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        public DateTime Modified_Date { get; set; }

    }
}