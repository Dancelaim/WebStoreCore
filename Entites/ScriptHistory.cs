using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Keyless]
    [Table("ScriptHistory")]
    public partial class ScriptHistory
    {
        public short? Script { get; set; }
    }
}
