namespace SRP.After
{
    public class EmailSender
    {
        //Cada clase tiene una responsabilidad única, lo que facilita mantenimiento y pruebas unitarias.
        public void Send(string report) => Console.WriteLine("Correo enviado con el reporte.");
    }
}
