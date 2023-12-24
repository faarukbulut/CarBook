using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogLast3WithAuthorsQueryHandler : IRequestHandler<GetBlogLast3WithAuthorsQuery, List<GetBlogLast3WithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogLast3WithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogLast3WithAuthorsQueryResult>> Handle(GetBlogLast3WithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogLast3WithAuthors();
            return values.Select(x => new GetBlogLast3WithAuthorsQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorName = x.Author.Name,
            }).ToList();
        }
    }
}
