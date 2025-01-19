namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class DakoOnlyVehiclesController : Controller
{
    [HttpGet("accounts/{accountuid}/dakoonlyvehicles")]
    public ActionResult<IEnumerable<DakoOnlyVehicle>> GetDakoOnlyVehicles(string accountuid)
    {
        return null;
    }
}