using Microsoft.AspNetCore.Mvc;
using XmlDeserializationExample;

[ApiController]
[Route("[controller]")]
public class PFEnviaMotorCredito : ControllerBase
{

    [HttpPost("receber-xml")]
    // [Consumes("application/xml")]
    public IActionResult ReceberXML([FromBody] Envelope envelope)
    {
        return Ok(envelope);
    }

}
