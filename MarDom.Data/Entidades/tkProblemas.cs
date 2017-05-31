using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarDom.Data.Entidades
{
    [Table("Problemas")]
    public class tkProblemas
    {
        public tkProblemas()
        {
          
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Categoria Id")]
        public int CategoriaId { get; set; }
        [MaxLength(200)]
        [StringLength(200)]
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

       
    }
}
