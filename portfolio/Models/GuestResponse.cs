using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspWorkshop.Models {
    public class GuestResponse {
        [Required(ErrorMessage = "Proszę podać imię i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać swój e-mail")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać swój telefon")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę wybrać opcję")]
        public bool? WillAttend { get; set; }
    }
}