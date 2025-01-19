namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class DakoOnlyDriversController : Controller
{
    [HttpGet("accounts/{accountuid}/dakoonlydrivers")]
    public ActionResult<IEnumerable<DakoOnlyDriver>> GetDakoOnlyDrivers(string accountuid)
    {
        return null;
    }
}
