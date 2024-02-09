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
    internal class CategoryServices : ICategoryServices
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryServices(IRepository<Category> repository, IMapper mapper)
        {
            _categoryRepository = repository;
            _mapper = mapper;   
        }
        public async Task Delete(int Id)
        {
            await _categoryRepository.Delete(Id);
        }

        public async Task<Category> Get(int Id)
        {
            return _mapper.Map<Category>(await _categoryRepository.GetById(Id));

        }

        public async Task<List<Category>> GetAll()
        {
            return _mapper.Map<List<Category>>( await _categoryRepository.GetAll());
        }

        public async Task Insert(Category category)
        {
            await _categoryRepository.Insert(category);
            await _categoryRepository.Save();
        }

        public async Task Update(Category category)
        {
            await _categoryRepository.UpDate(category);
            await _categoryRepository.Save();
        }
    }
}
