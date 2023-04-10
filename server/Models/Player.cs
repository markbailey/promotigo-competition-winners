namespace Promotigo.Models
{
  public class Player : DBRecord
  {
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Town { get; set; }
    public string County { get; set; }
    public string Country { get; set; }
  }
}