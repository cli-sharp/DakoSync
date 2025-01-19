namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class DakoOnlyVehiclesController : Controller
{
    [HttpGet("accounts/{accountUid}/dakoOnlyVehicles")]
    public ActionResult<IEnumerable<DakoOnlyVehicle>> GetDakoOnlyVehicles(string accountUid)
    {
        return Ok();
    }
}