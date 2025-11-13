using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Before
{
    public class ReportServices
    {
        /*
            Constructor con demasiados parámetros (difícil de leer y mantener).
            Muchos parámetros pueden ser opcionales, pero hay que pasarlos igual.
            Violación de la legibilidad y principio de claridad.
        */
        public void GenerateReport() { 
            var report = new Report(
                "Sales Report Q4",
                "Company Confidential",
                "Data and graphs for Q4...",
                "Generated automatically",
                "Luis Córdova",
                DateTime.Now,
                "PDF"
            );            
        }

    }
}
