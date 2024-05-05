namespace Memberships.DTOs.MembershipByUser
{
    public class UpdateMembershipByUserDto
    {
        public int? UserId { get; set; }

        public int? MembershipId { get; set; }

        public int? MembershipStatusId { get; set; }
    }
}
