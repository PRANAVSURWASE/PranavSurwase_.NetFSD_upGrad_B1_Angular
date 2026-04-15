using HealthCareAPI.DTOs;

namespace HealthCareAPI.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientReadDto>> GetAll();
        Task<PatientReadDto> GetById(int id);
        Task Add(PatientCreateDto dto);
        Task Update(int id, PatientCreateDto dto);
        Task Delete(int id);
    }
}
