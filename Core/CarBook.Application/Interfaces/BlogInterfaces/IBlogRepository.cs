using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogLast3WithAuthors();
        List<Blog> GetAllBlogWithAuthors();
        List<Blog> GetBlogByAuthorId(int id);
    }
}
