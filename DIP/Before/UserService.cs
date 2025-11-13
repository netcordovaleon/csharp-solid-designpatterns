namespace DIP.Before
{
    public class UserService
    {
        //UserService depende directamente de FileLogger. Difícil de cambiar o testear.
        private readonly FileLogger _logger = new FileLogger();

        public void Register(string user)
        {
            _logger.Log($"Usuario {user} registrado");
        }
    }
}
