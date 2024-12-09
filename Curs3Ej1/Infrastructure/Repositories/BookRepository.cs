using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    internal class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;

        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Guid> AddAsync(Book book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
            return book.Id;
        }

        Task IBookRepository.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Book>> IBookRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Book> IBookRepository.GetByAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IBookRepository.UpdateAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
