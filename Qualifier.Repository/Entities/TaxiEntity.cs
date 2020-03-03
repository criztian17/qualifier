using System.ComponentModel.DataAnnotations;

namespace Qualifier.Repository.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(6,MinimumLength = 6 , ErrorMessage = "The {0} field must have {1} characters.")]
        [Required(ErrorMessage = "The {0} field is mandatory.")]
        public string Plaque { get; set; }
    }
}
