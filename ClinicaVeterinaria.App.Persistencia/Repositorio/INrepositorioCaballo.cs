using System.Collections.Generic;  //libreria donde se definen las interfaces
using prueva.App.dominio;
 
namespace prueva.App.persistencia
{
    public interface INRepositorioCaballo
    {
        Paciente AddPaciente(Paciente paciente);  /// realizar análisis a todas estas líneas
        void DeletePaciente(int idpaciente);
        IEnumerable<Paciente> GetAllPacientes();
        Paciente GetPaciente(int idpaciente);
        Paciente UpdatePaciente(Paciente paciente);
    }
 
    
 
}