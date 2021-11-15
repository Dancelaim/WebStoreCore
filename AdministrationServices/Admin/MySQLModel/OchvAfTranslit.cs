using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfTranslit
    {
        public string Type { get; set; }
        public int GroupId { get; set; }
        public int Value { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }
    }
}
