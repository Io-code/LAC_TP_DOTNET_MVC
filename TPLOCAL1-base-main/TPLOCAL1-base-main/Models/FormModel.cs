using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Genre { get; set; }

        public string Adresse { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Code postal invalide")]
        public string CodePostal { get; set; }

        public string Ville { get; set; }

        [EmailAddress(ErrorMessage = "Email invalide")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de début")]
        public DateTime DateDebut { get; set; }

        public string TypeFormation { get; set; }

        public string CobolFormation { get; set; }
        public string CSharpFormation { get; set; }
    }
}
