using System.ComponentModel.DataAnnotations;

namespace Qualifier.Repository.Entities
{
    public partial class TaxiEntity
    {
        /// <summary>
        /// Taxi Id
        /// </summary>
        [Key]
        public int TaxiId { get; set; }

        /// <summary>
        /// Car Plate
        /// </summary>
        [MaxLength(9)]
        public string CarPlate { get; set; }
    }
}
