using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollectionMission4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string DirectorFirst { get; set; }
        [Required]
        public string DirectorLast { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public CategoryList Category { get; set; }
    }
}
