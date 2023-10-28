namespace Tranning.Models
{
    public class LoginModel
    {
        // day la noi dinh nghia cac truong du lieu can thao tac trong bang users (vi phan login lien quan den bang users)
        public string? UserID { get; set; }
        public string? RoleID { get; set; }
        public string? Username { get; set; }
        public string? EmailUser { get; set; }
        public string? PhoneUser { get; set; }
        public string? ExtraCode { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
    }
}
