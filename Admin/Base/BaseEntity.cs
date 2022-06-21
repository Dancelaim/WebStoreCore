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

        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set;}
        public bool IsArchive  {get; set;}
    }
}
