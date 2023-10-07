using Ops.Core.Enums;
using Ops.Core.Intefaces;

namespace Ops.Core.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
