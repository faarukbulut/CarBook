﻿using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                BlogID = x.BlogID,
                CommentID= x.CommentID,
                CreatedDate= x.CreatedDate,
                Description= x.Description,
                Name= x.Name,
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlogID == id).ToList();
        }

        public int GetCommentCountByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlogID == id).Count();
        }

        public void Remove(int id)
        {
            var value = _context.Comments.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
