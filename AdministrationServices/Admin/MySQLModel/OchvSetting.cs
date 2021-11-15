using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvSetting
    {
        public int SettingId { get; set; }
        public int StoreId { get; set; }
        public string Code { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Serialized { get; set; }
    }
}
