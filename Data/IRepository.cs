using System.Threading.Tasks;
using ProjectShcool_Api.Models;

namespace ProjectShcool_Api.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();


        Task<Aluno[]> GetAlunosAsync(int ProfessorId, bool includeProf);
        Task<Aluno[]> GetAlunosByProfessorAsync(int ProfessorId, bool includeProf);
        Task<Aluno> GetAlunosById(int AlunoId, bool includeProf);


        Task<Professor[]> GetProfessorAsync(bool includeAluno);

        Task<Professor> GetProfessorById(int AlunoId, bool includeAluno);

    }
}