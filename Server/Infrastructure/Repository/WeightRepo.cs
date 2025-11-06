using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class WeightRepo : IWeightInterface
{
    private readonly ApplicationDbContext _context;

    public WeightRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WeightLogs>> GetWeights()
    {
        return await _context.WeightLog.ToListAsync();
    }

    public async Task<WeightLogs> AddWeightInfo(WeightLogs weightLogs)
    {

        var addWeight = new WeightLogs
        {
            CurrentWeight = weightLogs.CurrentWeight,
            WeightUnit = weightLogs.WeightUnit,
            Notes = weightLogs.Notes,
            IsGoalAchieved = false,
            loggedAt = weightLogs.loggedAt
        };

        _context.Add(addWeight);
        await _context.SaveChangesAsync();

        return addWeight;
    }
}