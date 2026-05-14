namespace ControleEstoque.API.Services
{
    public class PasswordService : IPasswordService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string Hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, Hash);
        }
    }
}
