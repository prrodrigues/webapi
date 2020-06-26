using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectShcool_Api.Models;

namespace ProjectShcool_Api.Data
{
    public class Repository : IRepository
    {
        public DataContext _context { get; }
        public Repository(DataContext context)
        {
            _context = context;


        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<Aluno[]> GetAlunosAsync(int ProfessorId, bool includeProf)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProf)
            {
                query = query.Include(p => p.professor);
            }
            query = query.AsNoTracking()
                        .OrderBy(a => a.id)
                        .Where(prof => prof.id == ProfessorId);

            return await query.ToArrayAsync();
        }

        public Task<Aluno[]> GetAlunosByProfessorAsync(int ProfessorId, bool includeProf)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Aluno> GetAlunosById(int AlunoId, bool includeProf)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProf)
            {
                query = query.Include(p => p.professor);
            }
            query = query.AsNoTracking()
                        .OrderBy(a => a.id)
                        .Where(aluno => aluno.id == AlunoId);

            return await query.FirstOrDefaultAsync();
        }

        public Task<Professor[]> GetProfessorAsync(bool includeAluno)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor> GetProfessorById(int AlunoId, bool includeAluno)
        {
            throw new System.NotImplementedException();
        }
    }
}