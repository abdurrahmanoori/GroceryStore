using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Users
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Last Name")]
        public string? LastName { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        [Display(Name="E-mail")]
        public string? Email { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        [Display(Name ="Home Number")]
        public byte? HomeNo { get; set; }
        [Display(Name="Tazkira Number")]
        public int? TazkiraNo { get; set; }
        public string? Photo { get; set; }
        public string Password { get; set; }
        [Compare(otherProperty: "Password", ErrorMessage = "Passwords are not match!")]
        [Display(Name ="Confrim Password")]
        public string ConfirmPassword { get; set; }
    }
}
