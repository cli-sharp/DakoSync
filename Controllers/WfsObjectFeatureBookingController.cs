namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectFeatureBookingController : Controller
{
    [HttpPost("accounts/{accountUid}/wfsObjects/{objectUid}/featureBooking")]
    [ProducesResponseType(typeof(WfsObjectFeatureBooking), 201)]
    public ActionResult<WfsObjectFeatureBooking> CreateWfsObjectFeatureBooking(
        string accountUid, string objectUid, [FromBody] WfsObjectFeatureBooking wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{objectUid}/featureBooking")]
    [ProducesResponseType(typeof(WfsObjectFeatureBooking), 200)]
    public ActionResult<WfsObjectFeatureBooking> ReadWfsObjectFeatureBooking(
        string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{objectUid}/featureBooking")]
    [ProducesResponseType(typeof(WfsObjectFeatureBooking), 200)]
    public ActionResult<WfsObjectFeatureBooking> UpdateWfsObjectFeatureBooking(
        string accountUid, string objectUid, [FromBody] WfsObjectFeatureBooking wfsObject)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{objectUid}/featureBooking")]
    [ProducesResponseType(204)]
     public ActionResult DeleteWfsObjectFeatureBooking(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
