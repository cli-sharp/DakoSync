namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectsController : Controller
{
    [HttpGet("accounts/{accountUid}/wfsObjects")]
    [ProducesResponseType(typeof(IEnumerable<string>), 200)]
    public ActionResult<IEnumerable<string>> ReadWfsObjects(string accountUid)
    {
        return Ok();
    }

    [HttpPost("accounts/{accountUid}/wfsObjects")]
    [ProducesResponseType(typeof(WfsObject), 201)]
    public ActionResult<WfsObject> CreateWfsObject(string accountUid, [FromBody] WfsObject wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{objectUid}")]
    [ProducesResponseType(typeof(WfsObject), 200)]
    public ActionResult<WfsObject> ReadWfsObject(string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{objectUid}")]
    [ProducesResponseType(typeof(WfsObject), 200)]
    public ActionResult<WfsObject> UpdateWfsObject(
        string accountUid, string objectUid, [FromBody] WfsObject wfsObject)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{objectUid}")]
    [ProducesResponseType(204)]
     public ActionResult DeleteWfsObject(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
