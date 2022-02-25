using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("Article")]
    public partial class DbArticle : Base.BaseEntity
    {
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
        [Column("ArticleSeoId")]
        public Guid? ArticleSeoId { get; set; }
        [StringLength(255)]
        public string ImagePath { get; set; }
        public bool Enabled { get; set; }
        public int? Rating { get; set; }

        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("Articles")]
        public virtual DbProductGame ProductGame { get; set; }
        [ForeignKey(nameof(ArticleSeoId))]
        [InverseProperty("Articles")]
        public virtual DbSeo Seo { get; set; }
    }
}
