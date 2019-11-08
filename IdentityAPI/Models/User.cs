using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Fullname required")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Username required")]
        [MinLength(6, ErrorMessage = "Min 6 chars required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [MinLength(8, ErrorMessage = "Min 8 chars required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }       
        
        public string role { get; set; }

        public string Status { get; set; }
    }
}
