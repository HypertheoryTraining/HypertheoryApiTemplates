

using Api.Configuration;
using Microsoft.FeatureManagement.Mvc;

namespace Api.Controllers;

[FeatureGate(ApiFeatureManagementOptions.TacosFeature)]
public class DemoController : ControllerBase
{
    [HttpGet("tacos2")]
    public IActionResult GetTacos()
    {   
        // Feature Management won't hide these from Swashbuckle - there is a way to do it: https://github.com/Azure/AppConfiguration/issues/67
        return Ok("Tacos are enabled!");
    }
    
}