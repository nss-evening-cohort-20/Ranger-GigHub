namespace Ranger_GigHub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirebaseUid { get; set; }
        public string UserName { get; set; }
        public int UserZipcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SocialMedia { get; set; }
        public int UserRoleId { get; set; }
    }
}
