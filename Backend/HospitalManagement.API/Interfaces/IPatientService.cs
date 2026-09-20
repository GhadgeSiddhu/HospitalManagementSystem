using HospitalManagement.API.Models;

namespace HospitalManagement.API.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
    }
}
