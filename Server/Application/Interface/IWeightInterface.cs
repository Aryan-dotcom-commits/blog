using Domain.Entities;

public interface IWeightInterface
{
    Task<IEnumerable<WeightLogs>> GetWeights();

    Task<WeightLogs> AddWeightInfo(WeightLogs weightLogs);
}