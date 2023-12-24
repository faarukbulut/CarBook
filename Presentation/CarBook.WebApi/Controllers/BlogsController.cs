using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ekleme Başarıyla Tamamlandı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Silme Başarıyla Tamamlandı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme Başarıyla Tamamlandı");
        }

        [HttpGet("GetBlogLast3WithAuthors")]
        public async Task<IActionResult> GetBlogLast3WithAuthors()
        {
            var values = await _mediator.Send(new GetBlogLast3WithAuthorsQuery()); 
            return Ok(values);
        }

        [HttpGet("GetAllBlogWithAuthors")]
        public async Task<IActionResult> GetAllBlogWithAuthors()
        {
            var values = await _mediator.Send(new GetAllBlogWithAuthorsQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId/{id}")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
