namespace Qualifier.Common.Dtos.BaseModels
{
    public interface ITaxiModel
    {
        /// <summary>
        /// Taxi Id
        /// </summary>
        int TaxiId { get; set; }

        /// <summary>
        /// Car Plate
        /// </summary>
        string CarPlate { get; set; }
    }
}
