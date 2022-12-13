namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService() ;
            ILoggerService fileLoggerService= new FileLoggerService() ;

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasVuruYap(ihtiyacKrediManager, new DatabaseLoggerService ());

            List<IKrediManager> Krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(Krediler);
        }
    }
}