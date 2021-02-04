using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Cinemaa
    {
        [Column("CinemaId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Column("CinemaType")]
        [StringLength(50)]
        [Required]
        public String Type { get; set; }
        [Column("CinemaName")]
        [StringLength(50)]
        [Required]
        public String Name { get; set; }
        [ForeignKey("MovieId")]
        public List<Movie> movies { get; set; }

    }
}
