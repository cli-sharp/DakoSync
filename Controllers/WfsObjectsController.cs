namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectsController : Controller
{
    [HttpGet("accounts/{accountUid}/wfsObjects")]
    public ActionResult<IEnumerable<string>> ReadWfsObjects(string accountUid)
    {
        return Ok();
    }

    [HttpPost("accounts/{accountUid}/wfsObjects")]
    public ActionResult<WfsObject> CreateWfsObject(string accountUid, [FromBody] WfsObject wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{objectUid}")]
    public ActionResult<WfsObject> ReadWfsObject(string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{objectUid}")]
    public ActionResult<WfsObject> UpdateWfsObject(
        string accountUid, string objectUid, [FromBody] WfsObject wfsObject)
    {
        return Created();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{objectUid}")]
     public ActionResult DeleteWfsObject(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
