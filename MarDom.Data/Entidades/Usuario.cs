using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.Entidades
{
    [Table("AspNetUsers")]
    public class Usuario
    {
        [Key]
        [MaxLength(128)]
        [Required]
        public string Id { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [Required]
        public bool EmailConfirmed { get; set; }
        [MaxLength]
        public string PasswordHash { get; set; }
        [MaxLength]
        public string SecurityStamp { get; set; }
        [MaxLength]
        public string PhoneNumber { get; set; }
        [Required]
        public bool PhoneNumberConfirmed { get; set; }
        [Required]
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        [Required]
        public bool LockoutEnabled { get; set; }
        [Required]
        public int AccessFailedCount { get; set; }
        [MaxLength(256)]
        [Required]
        public string UserName { get; set; }
        [MaxLength]
        public string Nombres { get; set; }
        [MaxLength]
        public string Apellidos { get; set; }
    }
}
