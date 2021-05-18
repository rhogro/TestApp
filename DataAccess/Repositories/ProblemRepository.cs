using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProblemRepository : IProblemRepository
    {
        private readonly Context.AppContext _context;

        public ProblemRepository()
        {
            _context = new Context.AppContext();
        }

        public Problem Create(Problem item)
        {
            return _context.Add(item).Entity;
        }

        public void Delete(Problem item)
        {
            _context.Remove(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Problem Get(int id)
        {
            return _context.Problems.Find(id);
        }

        public IQueryable<Problem> GetAll()
        {
            return _context.Problems;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Problem Update(Problem item)
        {
            return _context.Update(item).Entity;
        }
    }
}
