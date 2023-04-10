namespace Promotigo.Models
{
  public class CompetitionEntry : DBRecord
  {
    public Guid CompetitionId { get; set; }
    public Guid PlayerId { get; set; }
    public Boolean IsWinner { get; set; }
  }
}