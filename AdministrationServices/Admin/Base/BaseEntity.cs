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
        public Guid Id { get; set; }
        public DateTime CreateDate { get { return CreateDate; } set { value = DateTime.Now; } }
        public DateTime UpdateDate { get; set;}
        public bool IsArchive   {get; set;}

        //protected BaseEntity(Guid id)
        //{
        //    Id = id;
        //}

    }
}
