namespace DIP.Before
{
    public class FileLogger
    {
        public void Log(string message) => File.WriteAllText("log.txt", message);
    }
}
