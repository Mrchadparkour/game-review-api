using System.Collections.Generic;

namespace game_review_api.Models
{
    public class Game
    {
        // public int Id { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }
        public string Oneword { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<string> Platforms { get; set; }
    }
}