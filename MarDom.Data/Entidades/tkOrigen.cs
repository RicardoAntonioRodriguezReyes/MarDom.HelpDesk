using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarDom.Data.Entidades
{
    [Table("tkOrigen")]
    public class tkOrigen
    {
        public tkOrigen()
        {
         
        }

        [Key]
      
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
      
        [MaxLength(150)]
        [StringLength(150)]
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
     
        [Required]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

  
    }
}
