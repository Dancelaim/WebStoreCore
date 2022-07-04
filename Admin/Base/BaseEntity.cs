using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Base
{
    public class BaseEntity : IBaseEntity
    {
        protected BaseEntity(Guid id)
        {
            Id = id;
        }
        protected BaseEntity() { }
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool IsArchived { get; set;}
    }
}
