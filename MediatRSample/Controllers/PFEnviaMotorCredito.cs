using Microsoft.AspNetCore.Mvc;
using Xml2CSharp;


[ApiController]
[Route("[controller]")]
public class PFEnviaMotorCredito : ControllerBase
{

    [HttpPost("receber-xml")]
    [Consumes("application/xml")]
    [Produces("application/xml")]
    public IActionResult ReceberXML([FromBody] Envelope envelope)
    {
        return Ok(envelope);
    }

}
