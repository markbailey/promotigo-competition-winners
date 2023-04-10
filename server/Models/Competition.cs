namespace Promotigo.Models
{
  public class Competition : DBRecord
  {
    public Guid ClientId { get; set; }
    public string Title { get; set; }
    public DateTime OpeningDate { get; set; }
    public DateTime ClosingDate { get; set; }
    public Boolean WinnersDrawn { get; set; }
  }
}