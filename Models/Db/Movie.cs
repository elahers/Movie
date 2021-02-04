using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Db
{
    public class Movie
    {
        [Column("MovieId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Column("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("Genere")]
        [Required]
        [StringLength(50)]
        public String Genre { get; set; }
        [Column("Duration")]
        [Required]
        public int Duration { get; set; }
        [Column("Summary")]
        [Required]
        [Text]
        public string Summary { get; set; }

        [ForeignKey("ImageID")]
        public virtual Image Image { get; set; }
       
    }
}
