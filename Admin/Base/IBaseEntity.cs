using System;

namespace Admin.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; }
        bool IsArchived { get; set; }
    }
}