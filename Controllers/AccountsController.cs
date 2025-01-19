namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountsController : Controller
{
    [HttpGet("accounts")]
    [ProducesResponseType(typeof(IEnumerable<string>), 200)]
    public ActionResult<IEnumerable<string>> ReadAccounts()
    {
        return Ok();
    }

    [HttpPost("accounts")]
    [ProducesResponseType(typeof(Account), 201)]
    public ActionResult<Account> CreateAccount([FromBody] Account account)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}")]
    [ProducesResponseType(typeof(Account), 200)]
     public ActionResult<Account> ReadAccount(string accountUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}")]
    [ProducesResponseType(typeof(Account), 200)]
    public ActionResult<Account> UpdateAccount(string accountUid, [FromBody] Account account)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}")]
    [ProducesResponseType(204)]
     public ActionResult DeleteAccount(string accountUid)
    {
        return NoContent();
    }
}