using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFilm.Models
{
    public class Film { 
    
        // id field required by the database for the primary key
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)] // specifies the type of data (Date).
        public DateTime ReleaseDate { get; set; }
        // The user not required to enter time information in the date field
        // Only the date is displayed, not time information.

        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }
}
