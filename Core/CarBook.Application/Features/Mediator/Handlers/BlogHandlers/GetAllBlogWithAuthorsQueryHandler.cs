using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogWithAuthorsQueryHandler : IRequestHandler<GetAllBlogWithAuthorsQuery, List<GetAllBlogWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogWithAuthorsQueryResult>> Handle(GetAllBlogWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogWithAuthors();
            return values.Select(x => new GetAllBlogWithAuthorsQueryResult
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
