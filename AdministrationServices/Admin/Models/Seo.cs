using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Seo
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string MetaTagTitle { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid SeoId { get; set; }
        public string MetaTagDescription { get; set; }
        public string MetaTagKeyWords { get; set; }
        public string Seotags { get; set; }
        public string CustomTitle1 { get; set; }
        public string CustomTitle2 { get; set; }
        public string CustomImageTitle { get; set; }
        public string CustomImageAlt { get; set; }
        public string MetaRobots { get; set; }
        public string UrlKeyWord { get; set; }
        public string Seoimage { get; set; }
    }
}
