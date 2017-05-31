using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.Entidades
{
    [Table("tkCategoria")]
    public class tkCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string Descripcion { get; set; }
        [Required]


        public int tkSeccion { get; set; }

        [Required]
        public bool Estado { get; set; }


    }
}
