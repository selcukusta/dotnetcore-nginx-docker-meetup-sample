namespace app.Services
{
    public class OutputLogService : ILogService
    {
        public string Write(string message)
        {
            return message;
        }
    }
}