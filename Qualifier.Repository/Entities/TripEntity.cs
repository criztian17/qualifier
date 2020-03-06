using System;
using System.ComponentModel.DataAnnotations;

namespace Qualifier.Repository.Entities
{
    /// <summary>
    /// Trip entity
    /// </summary>
    public partial class TripEntity
    {
        /// <summary>
        /// Trip Id
        /// </summary>
        [Key]
        public int TripId { get; set; }

        /// <summary>
        /// Represents the start date of the trip
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Shows the start local date of the trip
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime LocalDate => StartDate.ToLocalTime();

        /// <summary>
        /// Represents the end date of the trip
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Represents the end local date of the trip
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime? EndLocalDate => EndDate?.ToLocalTime();

        /// <summary>
        /// Destination
        /// </summary>
        [MaxLength(100)]
        public string Source { get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        [MaxLength(100)]
        public string Target { get; set; }

        /// <summary>
        /// Service qualification
        /// </summary>
        public float Qaulification { get; set; }

        /// <summary>
        /// Origen location latitude
        /// </summary>
        public string SourceLatitude { get; set; }

        /// <summary>
        /// Origen location longitude
        /// </summary>
        public string SourceLongitude { get; set; }

        /// <summary>
        /// Destination location latitud
        /// </summary>
        public string TargetLatitude { get; set; }

        /// <summary>
        /// Destination location longitude 
        /// </summary>
        public string TargetLongitude { get; set; }

        /// <summary>
        /// Trip observations 
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// TaxiEntity object reference
        /// </summary>
        public TaxiEntity Taxi { get; set; }

    }
}
