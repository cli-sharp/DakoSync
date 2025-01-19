namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectFeatureBookingController : Controller
{
    [HttpPost("accounts/{accountUid}/wfsObjects/{ObjectUid}/featureBooking")]
    public ActionResult<WfsObjectFeatureBooking> CreateWfsObjectFeatureBooking(
        string accountUid, string objectUid, [FromBody] WfsObjectFeatureBooking wfsObject)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsObjects/{ObjectUid}/featureBooking")]
    public ActionResult<WfsObjectFeatureBooking> ReadWfsObjectFeatureBooking(
        string accountUid, string objectUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsObjects/{ObjectUid}/featureBooking")]
    public ActionResult<WfsObjectFeatureBooking> UpdateWfsObjectFeatureBooking(
        string accountUid, string objectUid, [FromBody] WfsObjectFeatureBooking wfsObject)
    {
        return Created();
    }

    [HttpDelete("accounts/{accountUid}/wfsObjects/{ObjectUid}/featureBooking")]
     public ActionResult DeleteWfsObjectFeatureBooking(string accountUid, string objectUid)
    {
        return NoContent();
    }
}
