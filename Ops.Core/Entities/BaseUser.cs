namespace Ops.Core.Entities
{
    public abstract class BaseUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string? Image { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
