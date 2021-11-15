using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvBmPostVideo
    {
        public int PostId { get; set; }
        public string Video { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
    }
}
