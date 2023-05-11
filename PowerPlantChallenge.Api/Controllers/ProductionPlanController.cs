using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerPlantChallenge.Api.Dtos;
using PowerPlantChallenge.Api.Services;
using System.Text.Json;

namespace PowerPlantChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionPlanController : ControllerBase
    {
        private readonly IProductionPlanService productionPlanService;

        public ProductionPlanController(IProductionPlanService productionPlanService)
        {
            this.productionPlanService = productionPlanService;
        }

        [HttpPost]
        public async Task<ActionResult<List<ProductionPlan>>> GetProductionPlan(Payload payload)
        {
            try
            {
                var response = await productionPlanService.GetProductionPlanAsync(payload);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
