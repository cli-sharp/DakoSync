namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectContractController : Controller
{
    [HttpPost("accounts/{accountUid}/wfsObjects/{ObjectUid}/contract")]
    public ActionResult<WfsObjectContract> CreateWfsObjectContract(
        string accountUid, string objectUid, [FromBody] WfsObjectContract wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{ObjectUid}/contract")]
    public ActionResult<WfsObjectContract> ReadWfsObjectContract(string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{ObjectUid}/contract")]
    public ActionResult<WfsObjectContract> UpdateWfsObjectContract(
        string accountUid, string objectUid, [FromBody] WfsObjectContract wfsObject)
    {
        return Created();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{ObjectUid}/contract")]
     public ActionResult DeleteWfsObjectContract(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
