using System;

namespace Application.DTOs.User
{
    public class UserAccountDto
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string? Specialization { get; set; }
        public string? Degree { get; set; }
        public string? ProfilePicture { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
    }
}