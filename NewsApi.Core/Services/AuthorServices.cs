using AutoMapper;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    public class AuthorServices : IAuthorServices
    {
        private readonly IRepository<Author> _authorRepository;
        private readonly IMapper _mapper;
        public AuthorServices(IRepository<Author> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public async Task Delete(int Id)
        {
           await _authorRepository.Delete(Id);   
        }

        public async Task<Author> Get(int Id)
        {
           return _mapper.Map<Author>(await _authorRepository.GetById(Id));
        }

        public async Task<List<Author>> GetAll()
        {
            return _mapper.Map<List<Author>>(await _authorRepository.GetAll());
        }

        public async Task Insert(Author author)
        {
            await _authorRepository.Insert(author);
            await _authorRepository.Save();
        }

        public async Task Update(Author author)
        {
            await _authorRepository.UpDate(author);
            await _authorRepository.Save();
        }
    }
}
