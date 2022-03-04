using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse_App.Models
{
    public class Guest
    {
        public int Id;
        [Required(ErrorMessage ="On vaja sisesta oma nime!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "On vaja sisetada email!")]
        [RegularExpression(@".+\@.+\..+",ErrorMessage ="Viga emaili sisestamiseks!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sisesta oma tel.number!")]
        [RegularExpression(@"\+372.+",ErrorMessage ="Vale telefoni number, Alguses +372...")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Tee oma valik!!")]
        public bool? WillAttend { get; set; }
    }
}