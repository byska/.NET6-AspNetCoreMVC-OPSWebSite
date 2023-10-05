using Ops.Core.Enums;
using Ops.Core.Intefaces;

namespace Ops.Core.Entities
{
    public abstract class BaseUser:IEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public bool IsActive { get; set; } = true;
        public string CreatedBy { get; set; } = "admin";
        public DateTime CreatedDate { get; set; } =DateTime.Now;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; }
        public string? ModifiedBy { get; set; } = "admin";
        public DateTime? ModifiedDate { get; set; }
        public string? DeletedBy { get; set; } = "admin";
        public DateTime? DeletedDate { get; set; }
    }
}
