namespace ISP.After
{
    public class Robot : IWorkable
    {
        //Ahora cada clase implementa solo lo que necesita.
        public void Work() => Console.WriteLine("Robot trabajando...");
    }
}
