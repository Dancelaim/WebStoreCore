using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDMetaDatum
    {
        public string Route { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string Tag { get; set; }
        public string CustomTitle1 { get; set; }
        public string CustomTitle2 { get; set; }
        public string CustomImageTitle { get; set; }
        public string CustomImageAlt { get; set; }
        public string MetaRobots { get; set; }
    }
}
