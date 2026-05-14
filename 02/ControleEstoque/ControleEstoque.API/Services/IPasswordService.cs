namespace ControleEstoque.API.Services
{
    public interface IPasswordService
    {
        // criptografar
        string HashPassword(string password); // Gera um hash seguro para a senha fornecida

        //verificar se é igual
        bool VerifyPassword(string password, string passwordHash); // Verifica se a senha fornecida corresponde ao hash armazenado
    }
}
