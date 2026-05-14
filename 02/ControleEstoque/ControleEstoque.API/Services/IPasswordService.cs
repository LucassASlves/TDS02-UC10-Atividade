namespace ControleEstoque.API.Services
{
    public interface IPasswordService
    {
        // criptografar
        string HashPassword(string password);

        // verificar se é igual
        bool VerifyPassword(string password, string hash);
    }
}
