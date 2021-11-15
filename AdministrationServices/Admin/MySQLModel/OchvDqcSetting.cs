using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDqcSetting
    {
        public int SettingId { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
