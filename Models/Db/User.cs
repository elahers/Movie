using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Cinema.Models.Db
{
    public class User
    {
        [Column("UserId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Column("FirstName")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("LastName")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("Mail")]
        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        [Column("Password")]
        [Required]
        public string Password { get; set; }
        [Column("Gender")]
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column("MobileNumber")]
        [Required]
        [StringLength(50)]
        public string MobileNumber { get; set; }
        [Column("BirthDate")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }


    }
}
