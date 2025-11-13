namespace DIP.After
{
    public class UserService
    {

        /*
        Puedes inyectar cualquier implementación (FileLogger, ConsoleLogger, DatabaseLogger, etc.) 
        */
        private readonly ILogger _logger;

        public UserService(ILogger logger)
        {
            _logger = logger;
        }

        public void Register(string user)
        {
            _logger.Log($"Usuario {user} registrado");
        }
    }
}
