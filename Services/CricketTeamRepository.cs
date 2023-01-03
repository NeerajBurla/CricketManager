using CricketManager.Models;
using CricketManager.Pages;
using Newtonsoft.Json;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace CricketManager.Services
{
    public class CricketTeamRepository : IDataRepository<CricketTeam>
    {
        public HttpClient Http;

        public List<CricketTeam> theData { get; set; }

        public CricketTeamRepository(HttpClient http)
        {
            Http = http;
        }

        public void Add(CricketTeam entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CricketTeam entity)
        {
            //Code to delete team from Team List
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/AddTeam.json");

            var jsonObj = JsonConvert.DeserializeObject<List<CricketTeam>>(json);

            var team = jsonObj.Where(p => p.Name == entity.Name).First();

            jsonObj.Remove(team);

            var updatedJson = JsonConvert.SerializeObject(jsonObj);

            System.IO.File.WriteAllText("wwwroot/JsonData/Addteam.json", updatedJson);

            //If a team is deleted also deleted all the players related to the particular team
            string newjson = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");

            var playerJsonObj = JsonConvert.DeserializeObject<List<addplayer>>(newjson);

            //var player = playerJsonObj.Where(p => p.Name == entity.Name).ToList();

            playerJsonObj.RemoveAll(p => p.TeamName == entity.Name);

            var removedPlayerJson = JsonConvert.SerializeObject(playerJsonObj);

            System.IO.File.WriteAllText("wwwroot/JsonData/aplayer.json", removedPlayerJson);
        }

        public List<CricketTeam> Get()
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/AddTeam.json");
            List<CricketTeam> teams = JsonConvert.DeserializeObject<List<CricketTeam>>(json);

            return teams;
        }

        public CricketTeam GetDetail(int Id)
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/AddTeam.json");
            List<CricketTeam> teams = JsonConvert.DeserializeObject<List<CricketTeam>>(json);
            var team = teams.Where(p => p.Id == Id).FirstOrDefault();
            return team;
        }

        public void Update(CricketTeam entity)
        {
            throw new NotImplementedException();
        }

        public List<CricketTeam> GetDataByName(string Name)
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/AddTeam.json");
            List<CricketTeam> teams = JsonConvert.DeserializeObject<List<CricketTeam>>(json);
            var team = teams.Where(p => p.Name == Name).ToList();
            return team;
        }
    }
}
