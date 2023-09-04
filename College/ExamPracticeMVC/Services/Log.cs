namespace ExamPracticeMVC.Services
{
    public interface ILog
    {
        void info(String message);
    }

    public class Log: ILog
    {
        public void info(String message)
        {
            Console.WriteLine(message);
        }
    }
}
