using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Artemis_Shield.Models
{
    public class BahamutArticles
    {
        [Key]
        public int article_id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public DateTime published_date { get; set; }
        public string summary { get; set; }
    }
}
