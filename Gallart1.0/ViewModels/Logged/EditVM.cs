using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gallart.ViewModels.Logged
{
    public class EditVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "*This field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Password { get; set; }

      
    }
}
