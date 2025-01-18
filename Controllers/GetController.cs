namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountsController : Controller
{
    [HttpGet("accounts")]
    public ActionResult<IEnumerable<Account>> GetAccounts()
    {
        return null;
    }

    [HttpGet("accounts/{accountuid}")]
     public ActionResult<Account> GetAccount(string accountuid)
    {
        return null;
    }
}

public class WfsObjectsController : Controller
{
    [HttpGet("accounts/{accountuid}/wfsobjects")]
    public ActionResult<IEnumerable<WfsObject>> GetWfsObjects(string accountuid)
    {
        return null;
    }
}

public class WfsDriversController : Controller
{
    [HttpGet("accounts/{accountuid}/wfsdrivers")]
    public ActionResult<IEnumerable<WfsDriver>> GetWfsDrivers(string accountuid)
    {
        return null;
    }
}

public class DakoOnlyDriversController : Controller
{
    [HttpGet("accounts/{accountuid}/dakoonlydrivers")]
    public ActionResult<IEnumerable<DakoOnlyDriver>> GetDakoOnlyDrivers(string accountuid)
    {
        return null;
    }
}

public class DakoOnlyVehiclesController : Controller
{
    [HttpGet("accounts/{accountuid}/dakoonlyvehicles")]
    public ActionResult<IEnumerable<DakoOnlyVehicle>> GetDakoOnlyVehicles(string accountuid)
    {
        return null;
    }
}