using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class HtmlBlocksChild
    {
        [Key]
        public Guid SiteBlockChildsId { get; set; }
        public Guid SiteBlockId { get; set; }
        public string Text { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Column("CSSClass")]
        [StringLength(50)]
        public string Cssclass { get; set; }
        public int? ChildOrder { get; set; }

        [ForeignKey(nameof(SiteBlockId))]
        [InverseProperty(nameof(HtmlBlock.HtmlBlocksChildren))]
        public virtual HtmlBlock SiteBlock { get; set; }
    }
}
