using PowerPlantChallenge.Api.Dtos;

namespace PowerPlantChallenge.Api.Services
{
    public class ProductionPlanService : IProductionPlanService
    {
        async public Task<List<ProductionPlan>> GetProductionPlanAsync(Payload payload)
        {
            // This service should contain the calculation to get the production plan
            // Caclulate the cost per MWh based on efficiency
            // This will give us an idea how much each powerplant will cost per MWh taken into account their efficiency

            payload.Powerplants.ForEach(p => p.Cost = CaclulateCostPerMWh(p, payload.Fuels));

            // Caclulate PMax of windturbine based on the wind percentage
            payload.Powerplants.Where(p => p.Type.ToLower() == "windturbine").ToList().ForEach(p => p.PMax = p.PMax * (payload.Fuels.Wind / 100));


            return await Task.Run(() =>
            {
                //throw new Exception("Error occured while calculating production plan.");
                return new List<ProductionPlan> {
                    new ProductionPlan
                    {
                        Name = "windpark1",
                        P = 75
                    },
                    new ProductionPlan
                    {
                        Name = "windpark2",
                        P = 18
                    },
                    new ProductionPlan
                    {
                        Name = "gasfiredbig1",
                        P = 200
                    },
                    new ProductionPlan
                    {
                        Name = "gasfiredbig2",
                        P = 0
                    },
                    new ProductionPlan
                    {
                        Name = "tj1",
                        P = 0
                    },
                    new ProductionPlan
                    {
                        Name = "tj2",
                        P = 0
                    }
                };
            });
        }

        double CaclulateCostPerMWh(Powerplant powerplant, Fuel fuels)
        {
            // Calculate cost per MWh
            double cost = powerplant.Type.ToLower() switch
            {
                "gasfired" => (1 / powerplant.Efficiency) * fuels.Gas,
                "turbojet" => (1 / powerplant.Efficiency) * fuels.Kerosine,
                "windturbine" => 0
            };
            return cost;
        }
    }
}
