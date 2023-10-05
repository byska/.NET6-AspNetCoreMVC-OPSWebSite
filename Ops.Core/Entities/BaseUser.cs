using Ops.Core.Enums;
using Ops.Core.Intefaces;

namespace Ops.Core.Entities
{
    public abstract class BaseUser: BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } 
    }
}
