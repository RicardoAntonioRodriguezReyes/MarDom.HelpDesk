using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarDom.Data.Entidades
{
    [Table("Tickets")]
    public class Tickets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public int PrioridadId { get; set; }
        [Required]
        public int EstadoId { get; set; }
        public int? SubDepartamentoId { get; set; }
        public int? AreaId { get; set; }
        public int? OrigenId { get; set; }
        [Required]
        public int CategoriaId { get; set; }
    
        [Required]
        public DateTime FechaSolicitud { get; set; }

        [MaxLength(256)]
        [Required]
        public string UsuarioCrea { get; set; }
        [MaxLength(256)]
        [Required]
        public string Usuario { get; set; }
        [MaxLength(256)]
        public string Agente { get; set; }
        [MaxLength(150)]
        [Required]
        public string Titulo { get; set; }
        [MaxLength(200)]
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
