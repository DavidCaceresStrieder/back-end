using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation.User
{
    [ComplexType]
    [Table("Users")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_usuario")]
        public int id_usuario { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("BirthDate")]
        public DateTime BirthDate { get; set; }

        [Column("Telephone")]
        public long Telephone { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("GetInformation")]
        public bool GetInformation { get; set; }


    }
}
