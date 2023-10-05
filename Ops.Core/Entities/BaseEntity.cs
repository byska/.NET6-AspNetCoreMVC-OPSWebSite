using Ops.Core.Enums;
using Ops.Core.Intefaces;

namespace Ops.Core.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public string CreatedBy { get; set; } = "admin";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? ModifiedBy { get; set; } = "admin";
        public DateTime? ModifiedDate { get; set; }
        public string? DeletedBy { get; set; } = "admin";
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
