using System;

namespace SES1BBackendAPI.Domain.Interface
{
    public interface IEntity
    {
        long Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
