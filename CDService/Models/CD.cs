using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CDService.Models
{
    public class CD
    {
        /* - Primärnyckel - */
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        [Display(Name = "Release date")] // Ändrar presentationsnamnet av kolumnen.
        [Required]
        [DataType(DataType.Date)] // Specificerar datumformatet.
        public DateTime ReleaseDate { get; set; }
    }
}
