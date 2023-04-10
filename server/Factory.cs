using Newtonsoft.Json;
using Promotigo.Models;

namespace Promotigo.Data
{
  public static class Factory
  {
    public static Player CreatePlayer()
    {
      List<Person> people = JSON<Person>.Load("data/people.json");
      Person person = people[new Random().Next(0, people.Count)];

      string[] domains = { "gmail.com", "hotmail.com", "hotmail.co.uk", "yahoo.com", "yahoo.co.uk", "outlook.com", "aol.com" };
      string emailAddress = $"{person.Forename.ToLower()}.{person.Surname.ToLower()}@{domains[new Random().Next(0, domains.Length)]}";
      string telephoneNumber = $"0{new Random().Next(700000000, 999999999)}";

      List<Address> addresses = JSON<Address>.Load("data/locations.json");
      Address address = addresses[new Random().Next(0, addresses.Count)];

      return new Player
      {
        Id = Guid.NewGuid(),
        Forename = person.Forename,
        Surname = person.Surname,
        Email = emailAddress,
        Telephone = telephoneNumber,
        Town = address.Town,
        County = address.County,
        Country = address.Country,
        DateCreated = DateTime.Now,
        DateUpdated = DateTime.Now
      };
    }

    public static Client CreateClient(string name)
    {
      return new Client
      {
        Id = Guid.NewGuid(),
        Name = name,
        DateCreated = DateTime.Now,
        DateUpdated = DateTime.Now
      };
    }

    public static Competition CreateCompetition(string title, Guid clientId)
    {
      return new Competition
      {
        Id = Guid.NewGuid(),
        Title = title,
        ClientId = clientId,
        OpeningDate = DateTime.Now,
        ClosingDate = DateTime.Now.AddMinutes(1),
        DateCreated = DateTime.Now,
        DateUpdated = DateTime.Now
      };
    }

    public static CompetitionEntry CreateCompetitionEntry(Guid competitionId, Guid playerId)
    {
      return new CompetitionEntry
      {
        Id = Guid.NewGuid(),
        CompetitionId = competitionId,
        PlayerId = playerId,
        IsWinner = false,
        DateCreated = DateTime.Now,
        DateUpdated = DateTime.Now
      };
    }
  }

  public static class JSON<T>
  {
    public static List<T> Load(string path)
    {
      string fullPath = System.IO.Path.Join(AppDomain.CurrentDomain.BaseDirectory, path);
      using (StreamReader r = new StreamReader(fullPath))
      {
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<T>>(json);
      }
    }
  }
}