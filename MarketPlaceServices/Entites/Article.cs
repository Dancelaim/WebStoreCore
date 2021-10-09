using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("Article")]
    public partial class Article
    {
        [Key]
        public Guid ArticleId { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        [StringLength(55)]
        public string ReadTime { get; set; }
        [StringLength(255)]
        public string Tags { get; set; }
        public Guid? ProductGameId { get; set; }
        [Column("SEOId")]
        public Guid? Seoid { get; set; }
        [StringLength(255)]
        public string ImagePath { get; set; }
        public bool Enabled { get; set; }
        public int? Rating { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArticleCreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArticleUpdateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ArticlePostTime { get; set; }

        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("Articles")]
        public virtual ProductGame ProductGame { get; set; }
        [ForeignKey(nameof(Seoid))]
        [InverseProperty("Articles")]
        public virtual Seo Seo { get; set; }
    }
}
