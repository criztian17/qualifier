using System;

namespace Qualifier.Common.Dtos.BaseModels
{
    public interface ITripModel
    {
        /// <summary>
        /// Trip Id
        /// </summary>
        int TripId { get; set; }

        /// <summary>
        /// Represents the start date of the trip
        /// </summary>
        DateTime StartDate { get; set; }

        /// <summary>
        /// Shows the start local date of the trip
        /// </summary>
        DateTime LocalDate { get; }

        /// <summary>
        /// Represents the end date of the trip
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// Represents the end local date of the trip
        /// </summary>
        DateTime? EndLocalDate { get; }

        /// <summary>
        /// Destination
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        string Target { get; set; }

        /// <summary>
        /// Service qualification
        /// </summary>
        float Qaulification { get; set; }

        /// <summary>
        /// Origen location latitude
        /// </summary>
        string SourceLatitude { get; set; }

        /// <summary>
        /// Origen location longitude
        /// </summary>
        string SourceLongitude { get; set; }

        /// <summary>
        /// Destination location latitud
        /// </summary>
        string TargetLatitude { get; set; }

        /// <summary>
        /// Destination location longitude 
        /// </summary>
        string TargetLongitude { get; set; }

        /// <summary>
        /// Trip observations 
        /// </summary>
        string Remarks { get; set; }

        /// <summary>
        /// Taxi interface object reference
        /// </summary>
        ITaxiModel InfoTaxi { get; set; }
    }
}
