using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Promotigo.Data;
using Promotigo.Models;

namespace Promotigo.Controllers
{
  [ApiController]
  [Route("api")]
  public class ApiController : ControllerBase
  {
    [HttpOptions]
    public ActionResult PreFlightRoute()
    {
      return NoContent();
    }

    [HttpGet("clients")]
    [EnableCors("MyPolicy")]
    public ActionResult<List<Client>> GetClients()
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        return db.Clients.ToList();
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpGet("clients/{clientId}/competitions")]
    [EnableCors("MyPolicy")]
    public ActionResult<List<Competition>> GetCompetitionsByClientId(string clientId)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        List<Competition> competitions = db.Competitions.Where((c) => c.ClientId == Guid.Parse(clientId)).ToList();
        return competitions.Count() > 0 ? competitions : NotFound();
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpGet("competitions/{competitionId}")]
    [EnableCors("MyPolicy")]
    public ActionResult<Competition> GetCompetitionById(string competitionId)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        Competition competition = db.Competitions.Where((c) => c.Id == Guid.Parse(competitionId)).First();
        return competition;
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpGet("competitions/{competitionId}/playerids")]
    [EnableCors("MyPolicy")]
    public ActionResult<List<Guid>> GetPlayerIdsByCompetitionId(string competitionId)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        List<CompetitionEntry> entries = db.CompetitionEntries.Where((e) => e.CompetitionId == Guid.Parse(competitionId)).ToList();
        List<Guid> ids = entries.Select((e) => e.PlayerId).ToList();
        return ids;
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpGet("competitions/{competitionId}/winners")]
    [EnableCors("MyPolicy")]
    public ActionResult<List<Player>> GetCompetitionWinners(string competitionId)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        List<CompetitionEntry> entries = db.CompetitionEntries.Where((e) => e.CompetitionId == Guid.Parse(competitionId) && e.IsWinner).ToList();
        return db.Players.Where((p) => entries.Select((e) => e.PlayerId).Contains(p.Id)).ToList();
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpPost("competitions/{competitionId}/winners")]
    [EnableCors("MyPolicy")]
    public ActionResult<List<Player>> DrawCompetitionWinners(string competitionId, [FromBody] string[] playerIds)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        Boolean winnersDrawn = db.HasCompetitionWinnersBeenDrawn(Guid.Parse(competitionId));
        if (winnersDrawn)
          return BadRequest("Winners have already been drawn for this competition.");

        List<Guid> playerGuids = playerIds.Select((id) => Guid.Parse(id)).ToList();
        List<Player> winners = db.DrawCompetitionWinners(Guid.Parse(competitionId), playerGuids);
        return winners;
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    [HttpPost("competitions/{competitionId}/winners/clear")]
    [EnableCors("MyPolicy")]
    public ActionResult ClearCompetitionWinners(string competitionId)
    {
      try
      {
        PromotigoContext db = new PromotigoContext();
        db.ClearCompetitionWinners(Guid.Parse(competitionId));
        return Ok();
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }
  }
}