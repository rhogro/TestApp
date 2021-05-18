using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class AnswerRepositry : IAnswerRepository
    {
        private readonly Context.AppContext _context;

        public AnswerRepositry()
        {
            _context = new Context.AppContext();
        }

        public Answer Create(Answer item)
        {
            return _context.Add(item).Entity;
        }

        public void Delete(Answer item)
        {
            _context.Remove(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Answer Get(int id)
        {
            return _context.Answers.Find(id);
        }

        public IQueryable<Answer> GetAll()
        {
            return _context.Answers;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Answer Update(Answer item)
        {
            return _context.Update(item).Entity;
        }
    }
}
