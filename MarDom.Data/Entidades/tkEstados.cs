using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarDom.Data.Entidades
{
    [Table("tkEstados")]
    public class tkEstados
    {
        public tkEstados()
        {
           
        }

        [Key]
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [MaxLength(100)]
        [StringLength(100)]
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
      
        [Required]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

      
    }
}
