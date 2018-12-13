using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _myAsp.Models {
    public class GuestResponse {
        [Required(ErrorMessage = "Wprowadź swoje imię i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wprowadź swój e-mail")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wprowadź swój telefon")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Wybierz jedną z opcji")]
        public bool? WillAttend { get; set; }


    }
}