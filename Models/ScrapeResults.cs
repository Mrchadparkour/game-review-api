using System.Collections.Generic;

namespace game_review_api.Models
{
    public class ScrapeResults
    {
        public List<Game> games { get; set; }
        public List<Game> emptyFields { get; set; }
        public List<string> failedUrls { get; set; }
    }
}