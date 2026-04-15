using HealthCareAPI.DTOs;
using HealthCareAPI.Models;
using HealthCareAPI.Repository;

namespace HealthCareAPI.Services
{
    public class PatientService:IPatientService
    {
        private readonly IGenericRepository<Patient> _repo;
        public PatientService(IGenericRepository<Patient> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<PatientReadDto>> GetAll()
        {
            var patients = await _repo.GetAll();

            return patients.Select(p => new PatientReadDto
            {
                PatientId = p.PatientId,
                Name = p.Name,
                Age = p.Age,
                Gender = p.Gender,
                ContactNumber = p.ContactNumber,
                Address = p.Address
            });
        }

        public async Task<PatientReadDto> GetById(int id)
        {
            var p = await _repo.GetById(id);
            if (p == null) throw new Exception("Patient not found");

            return new PatientReadDto
            {
                PatientId = p.PatientId,
                Name = p.Name,
                Age = p.Age,
                Gender = p.Gender,
                ContactNumber = p.ContactNumber,
                Address = p.Address
            };
        }

        public async Task Add(PatientCreateDto dto)
        {
            var patient = new Patient
            {
                Name = dto.Name,
                Age = dto.Age,
                Gender = dto.Gender,
                ContactNumber = dto.ContactNumber,
                Address = dto.Address
            };

            await _repo.Add(patient);
        }

        public async Task Update(int id, PatientCreateDto dto)
        {
            var patient = await _repo.GetById(id);
            if (patient == null) throw new Exception("Patient not found");

            patient.Name = dto.Name;
            patient.Age = dto.Age;
            patient.Gender = dto.Gender;
            patient.ContactNumber = dto.ContactNumber;
            patient.Address = dto.Address;

            await _repo.Update(patient);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

    }
}
