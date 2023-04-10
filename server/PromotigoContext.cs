using Microsoft.EntityFrameworkCore;
using Promotigo.Models;

namespace Promotigo.Data
{
  public class PromotigoContext : DbContext
  {
    public PromotigoContext()
    {
      string path = AppDomain.CurrentDomain.BaseDirectory;
      DbPath = System.IO.Path.Join(path, "promotigo.db");
    }


    public string DbPath { get; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Competition> Competitions { get; set; }
    public DbSet<Player> Players { get; set; }

    public DbSet<CompetitionEntry> CompetitionEntries { get; set; }

    public Boolean HasCompetitionWinnersBeenDrawn(Guid competitionId)
    {
      return Competitions
        .Where((e) => e.Id == competitionId)
        .First()
        .WinnersDrawn;
    }

    public List<Player> DrawCompetitionWinners(Guid competitionId, List<Guid> playerIds)
    {
      Competitions
        .Where((e) => e.Id == competitionId)
        .First()
        .WinnersDrawn = true;

      CompetitionEntries
        .Where((e) => e.CompetitionId == competitionId && playerIds.Contains(e.PlayerId))
        .ToList()
        .ForEach((e) => e.IsWinner = true);

      SaveChanges();
      return Players.Join(CompetitionEntries, (p) => p.Id, (e) => e.PlayerId, (p, e) => new { p, e })
        .Where((x) => x.e.CompetitionId == competitionId && x.e.IsWinner)
        .Select((x) => x.p)
        .ToList();
    }

    public void ClearCompetitionWinners(Guid competitionId)
    {
      Competitions
        .Where((e) => e.Id == competitionId)
        .First()
        .WinnersDrawn = false;

      CompetitionEntries
        .Where((e) => e.CompetitionId == competitionId && e.IsWinner)
        .ToList()
        .ForEach((e) => e.IsWinner = false);

      SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      Client[] clients = new Client[] {
        Factory.CreateClient("Brooks"),
        Factory.CreateClient("Coca Cola"),
        Factory.CreateClient("Ben & Jerrys")
      };

      Competition[] competitions = new Competition[] {
        Factory.CreateCompetition("Product launch instant win", clients[0].Id),
        Factory.CreateCompetition("Sampling with capital xtra", clients[1].Id),
        Factory.CreateCompetition("Share the love", clients[2].Id)
      };

      Player[] players = new Player[] {
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer(),
        Factory.CreatePlayer(), Factory.CreatePlayer()
      };

      CompetitionEntry[] entries = new CompetitionEntry[] {
        Factory.CreateCompetitionEntry(competitions[0].Id, players[0].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[1].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[2].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[3].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[4].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[5].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[6].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[7].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[8].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[9].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[10].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[11].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[12].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[13].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[14].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[15].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[16].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[17].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[18].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[19].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[20].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[21].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[22].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[23].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[24].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[25].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[26].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[27].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[28].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[29].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[30].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[31].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[32].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[33].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[34].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[35].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[36].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[37].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[38].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[39].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[40].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[41].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[42].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[43].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[44].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[45].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[46].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[47].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[48].Id),
        Factory.CreateCompetitionEntry(competitions[0].Id, players[49].Id),

        Factory.CreateCompetitionEntry(competitions[1].Id, players[0].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[1].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[2].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[3].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[4].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[5].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[6].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[7].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[8].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[9].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[10].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[11].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[12].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[13].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[14].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[15].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[16].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[17].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[18].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[19].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[20].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[21].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[22].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[23].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[24].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[25].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[26].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[27].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[28].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[29].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[30].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[31].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[32].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[33].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[34].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[35].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[36].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[37].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[38].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[39].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[40].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[41].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[42].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[43].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[44].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[45].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[46].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[47].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[48].Id),
        Factory.CreateCompetitionEntry(competitions[1].Id, players[49].Id),

        Factory.CreateCompetitionEntry(competitions[2].Id, players[0].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[1].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[2].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[3].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[4].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[5].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[6].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[7].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[8].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[9].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[10].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[11].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[12].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[13].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[14].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[15].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[16].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[17].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[18].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[19].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[20].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[21].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[22].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[23].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[24].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[25].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[26].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[27].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[28].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[29].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[30].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[31].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[32].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[33].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[34].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[35].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[36].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[37].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[38].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[39].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[40].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[41].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[42].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[43].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[44].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[45].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[46].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[47].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[48].Id),
        Factory.CreateCompetitionEntry(competitions[2].Id, players[49].Id),
      };

      modelBuilder.Entity<Client>().HasData(clients);
      modelBuilder.Entity<Competition>().HasData(competitions);
      modelBuilder.Entity<Player>().HasData(players);
      modelBuilder.Entity<CompetitionEntry>().HasData(entries);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
  }
}
