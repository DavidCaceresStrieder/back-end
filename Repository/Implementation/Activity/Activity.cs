using Repository.Implementation.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation.Activity
{
    
    [Table("Activity")]
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_actividad")]
        public int ID { get; set; }

        [Column("CreationDate")]
        public DateTime Date { get; set; }

        [ForeignKey("id_usuario")]
        [Column("id_usuario")]        
        public virtual Usuario Usuario { get; set; }

        [Column("Activitiy")]
        public string Actividad { get; set; }

    }
}
