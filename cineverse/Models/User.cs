namespace cineverse.Models
{
    public class User
    {
        public int UserID { get; set; }  // Primary key olarak kullanılacak
        public string Email { get; set; }  // Kullanıcının e-posta adresi
        public string PasswordHash { get; set; }  // Şifre hash'i
        public string Username { get; set; }  // Kullanıcı adı
        public string ProfileImage { get; set; }  // Profil resmi URL'si
        public DateTime CreatedAt { get; set; }  // Hesap oluşturulma tarihi
        public DateTime LastLogin { get; set; }  // Son giriş tarihi
    }
}
