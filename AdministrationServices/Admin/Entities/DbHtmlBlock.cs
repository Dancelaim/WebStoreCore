using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbHtmlBlock
    {
        public DbHtmlBlock()
        {
            HtmlBlocksChildren = new HashSet<DbHtmlBlocksChild>();
        }

        [Key]
        public Guid SiteBlockId { get; set; }
        [Column("ParentCSSClass")]
        [StringLength(50)]
        public string ParentCssclass { get; set; }
        [StringLength(55)]
        public string ParentTitle { get; set; }
        [Column("ChildCSSClass")]
        [StringLength(55)]
        public string ChildCssclass { get; set; }
        [StringLength(55)]
        public string SitePage { get; set; }
        public int? Order { get; set; }

        [InverseProperty(nameof(DbHtmlBlocksChild.SiteBlock))]
        public virtual ICollection<DbHtmlBlocksChild> HtmlBlocksChildren { get; set; }
    }
}
