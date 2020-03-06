using System;
using System.ComponentModel.DataAnnotations;

namespace Qualifier.Repository.Entities
{
    public partial class TripDetailEntity
    {
        /// <summary>
        /// Trip detail Id
        /// </summary>
        [Key]
        public int TripDetailId { get; set; }

        /// <summary>
        /// Date for the current moment
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Shows the local date for the current moment
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime LocalDate => Date.ToLocalTime();

        /// <summary>
        /// TripEntity object reference
        /// </summary>
        public TripEntity Trip { get; set; }
    }
}
