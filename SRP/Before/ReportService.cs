namespace SRP.Before
{
    public class ReportService
    {
        /*
        Aquí ReportService hace tres cosas distintas: generar, guardar y enviar reportes.
        Cualquier cambio en cómo se guardan o envían afecta a toda la clase.
         */
        public string GenerateReport()
        {
            // Lógica para generar un reporte
            return "Reporte generado.";
        }

        public void SaveToFile(string report)
        {
            File.WriteAllText("reporte.txt", report);
        }

        public void SendEmail(string report)
        {
            // Lógica para enviar correo con el reporte
            Console.WriteLine("Correo enviado con el reporte.");
        }
    }
}
