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