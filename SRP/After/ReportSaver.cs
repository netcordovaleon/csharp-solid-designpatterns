namespace SRP.After
{
    public class ReportSaver
    {
        //Cada clase tiene una responsabilidad única, lo que facilita mantenimiento y pruebas unitarias.
        public void Save(string report) => File.WriteAllText("reporte.txt", report);
    }
}
