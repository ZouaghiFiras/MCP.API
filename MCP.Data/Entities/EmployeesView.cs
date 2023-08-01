namespace CED.Data.Entities
{
    public class EmployeesView
    {
        public Guid Id { get; set; }

        public string? Initials { get; set; }

        public string? FirstName { get; set; }

        public string? PrefixLastName { get; set; }

        public string LastName { get; set; } = null!;

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? MobileNumber { get; set; }

        public string? Email { get; set; }

        public string? EmployeeNumber { get; set; }

        public string? EisNumber { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}