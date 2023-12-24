﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class CreateTagCloudCommand : IRequest
    {
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
