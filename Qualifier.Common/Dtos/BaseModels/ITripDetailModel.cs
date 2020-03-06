using System;

namespace Qualifier.Common.Dtos.BaseModels
{
    public partial interface ITripDetailModel
    {
        /// <summary>
        /// Trip detail Id
        /// </summary>
        int TripDetailId { get; set; }

        /// <summary>
        /// Date for the current moment
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Shows the local date for the current moment
        /// </summary>
        DateTime LocalDate { get; }

        /// <summary>
        /// TripEntity object reference
        /// </summary>
        ITripModel Trip { get; set; }
    }
}
