using CricketManager.Models;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CricketManager.Services
{
    public class PlayerRepository : IDataRepository<addplayer>
    {
        public List<addplayer> myDdlData { get; set; }

        public HttpClient Http;

        public PlayerRepository(HttpClient http)
        {
            Http = http;
        }

        public void Add(addplayer entity)
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");

            var jsonObj = JsonConvert.DeserializeObject<List<addplayer>>(json);

            jsonObj.Add(entity);


            var updatedJson = JsonConvert.SerializeObject(jsonObj);

            System.IO.File.WriteAllText("wwwroot/JsonData/aplayer.json", updatedJson);

        }

        public List<addplayer> Get()
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");
            myDdlData = JsonConvert.DeserializeObject<List<addplayer>>(json);
            return myDdlData;
        }

        public void Update(addplayer entity)
        {
            //Code to  player from Player List
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");

            var jsonObj = JsonConvert.DeserializeObject<List<addplayer>>(json);

            var player = jsonObj.Where(p => p.Name == entity.Name).First();

            player.Name = entity.Name;
            player.DateofBirth = entity.DateofBirth;
            player.Captain = entity.Captain;
            player.BattingOrder = entity.BattingOrder;
            player.BowlingStyle = entity.BowlingStyle;
            player.Rating = entity.Rating;
            player.Position = entity.Position;
            player.TeamName = entity.TeamName;

            var oldplayer = jsonObj.Where(p => p.Name == entity.Name).First();

            jsonObj.Remove(oldplayer);
            jsonObj.Add(player);


            var updatedJson = JsonConvert.SerializeObject(jsonObj);

            System.IO.File.WriteAllText("wwwroot/JsonData/aplayer.json", updatedJson);
        }



        public List<addplayer> GetDataByName(string Name)
        {
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");
            List<addplayer> players = JsonConvert.DeserializeObject<List<addplayer>>(json);

            List<addplayer> player = players.Where(p => p.TeamName == Name).ToList();

            return player;
        }

        public void Delete(addplayer entity)
        {
            //Code to delete player from Player List
            string json = System.IO.File.ReadAllText("wwwroot/JsonData/aplayer.json");

            var jsonObj = JsonConvert.DeserializeObject<List<addplayer>>(json);

            var player = jsonObj.Where(p => p.Name == entity.Name).First();

            jsonObj.Remove(player);

            var updatedJson = JsonConvert.SerializeObject(jsonObj);

            System.IO.File.WriteAllText("wwwroot/JsonData/aplayer.json", updatedJson);
        }

        public addplayer GetDetail(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
