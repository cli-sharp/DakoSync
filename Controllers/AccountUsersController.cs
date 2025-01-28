namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountUsersController : Controller
{
    [HttpGet("accounts/{accountUid}/users")]
    [ProducesResponseType(typeof(IEnumerable<string>), 200)]
    public ActionResult<IEnumerable<string>> ReadAccountUsers(string accountUid)
    {
        return Ok();
    }

    [HttpPost("accounts/{accountUid}/users")]
    [ProducesResponseType(typeof(AccountUser), 201)]
    public ActionResult<AccountUser> CreateAccountUser(string accountUid, [FromBody] AccountUser accountUser)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/users/{realName}")]
    [ProducesResponseType(typeof(AccountUser), 200)]
    public ActionResult<AccountUser> ReadAccountUser(string accountUid, string realName)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/users/{realName}")]
    [ProducesResponseType(typeof(AccountUser), 200)]
    public ActionResult<AccountUser> UpdateAccountUser(
        string accountUid, string realName, [FromBody] AccountUser accountUser)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/users/{realName}")]
    [ProducesResponseType(204)]
     public ActionResult DeleteAccountUser(string accountUid, string realName)
    {
        return NoContent();
    }
}
