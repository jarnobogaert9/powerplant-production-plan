using PowerPlantChallenge.Api.Dtos;

namespace PowerPlantChallenge.Api.Services
{
    public interface IProductionPlanService
    {
        Task<List<ProductionPlan>> GetProductionPlanAsync(Payload payload);
    }
}
