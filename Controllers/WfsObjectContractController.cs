﻿namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectContractController : Controller
{
    [HttpPost("accounts/{accountUid}/wfsObjects/{objectUid}/contract")]
    [ProducesResponseType(typeof(WfsObjectContract), 201)]
    public ActionResult<WfsObjectContract> CreateWfsObjectContract(
        string accountUid, string objectUid, [FromBody] WfsObjectContract wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{objectUid}/contract")]
    [ProducesResponseType(typeof(WfsObjectContract), 200)]
    public ActionResult<WfsObjectContract> ReadWfsObjectContract(string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{objectUid}/contract")]
    [ProducesResponseType(typeof(WfsObjectContract), 200)]
    public ActionResult<WfsObjectContract> UpdateWfsObjectContract(
        string accountUid, string objectUid, [FromBody] WfsObjectContract wfsObject)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{objectUid}/contract")]
    [ProducesResponseType(204)]
     public ActionResult DeleteWfsObjectContract(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
