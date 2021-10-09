using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id => Guid.NewGuid();
        public DateTime CreateDate => DateTime.Now;
        public DateTime UpdateDate;
        public bool IsArchive;

        //protected BaseEntity(Guid id)
        //{
        //    Id = id;
        //}

    }
}
