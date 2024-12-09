using Application.Use_Cases.Commands;
using MediatR;
using Domain.Repositories;
using Domain.Entities;
namespace Application.Use_Cases.CommandHandlers
{
    internal class CreateBookCommandHandlers : IRequestHandler<CreateBookCommand, Guid>
    {
        private readonly IBookRepository repository;

        public CreateBookCommandHandlers(IBookRepository repository) 
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Title = request.Title,
                Author = request.Author,
                ISBN = request.ISBN,
                PublicationDate = request.PublicationDate
            };
            return await repository.AddAsync(book);
        }
    }
}
