using System;
using System.ComponentModel.DataAnnotations;

namespace FilmCollectionMission4.Models
{
    public class CategoryList
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }

        public string Category { get; set; }
    }
}
