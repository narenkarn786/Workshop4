
using Microsoft.EntityFrameworkCore;

namespace Workshop4.Service
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDBContext _dbContext;

        public StudentService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student> AddStudent(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task DeleteStudent(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public Task<Student> UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudentById(string id)
        {
            var result=await _dbContext.Students.Where(s=>s.Id.ToString()==id).ToListAsync();
            return result;
        }
    }
}
