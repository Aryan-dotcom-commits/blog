using System.Linq.Expressions;
using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Diagnostics;

namespace Application.Services
{
    public class WeightServices
    {
        private readonly IWeightInterface _weightRepo;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WeightServices(IWeightInterface weightRepo, IHttpContextAccessor httpContextAccessor)
        {
            _weightRepo = weightRepo;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<WeightLogs>> GetWeights()
        {
            var weights = await _weightRepo.GetWeights();

            if (weights == null) return Enumerable.Empty<WeightLogs>();

            return weights;
        }

        public async Task<ApiResponse<WeightDTO>> AddWeightInfo(WeightLogs weightLogs)
        {
            var checkWeights = await _weightRepo.GetWeights();

            var weightDTO = new WeightDTO
            {
                CurrentWeight = weightLogs.CurrentWeight,
                WeightUnit = weightLogs.WeightUnit,
                Notes = weightLogs.Notes,
                IsGoalAchieved = weightLogs.IsGoalAchieved,
                loggedAt = weightLogs.loggedAt
            };

            if (checkWeights != null) return new ApiResponse<WeightDTO>
            {
                Success = false,
                Message = "User already has weight info, please edit or update the data instead of adding",
                Data = weightDTO,
                TraceId = _httpContextAccessor.HttpContext.TraceIdentifier
            };

            try
            {
                var addInfo = await _weightRepo.AddWeightInfo(weightLogs);

                return new ApiResponse<WeightDTO>
                {
                    Success = true,
                    Message = "Weight Added",
                    Data = weightDTO,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };
            } catch 
            {
                return new ApiResponse<WeightDTO>
                {
                    Success = false,
                    Message = "Error Adding weights",
                    Data = weightDTO,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };
            }
        }
    }
}