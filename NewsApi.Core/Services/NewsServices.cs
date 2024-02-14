using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    public class NewsServices : INewsServices
    {
        private readonly IRepository<News> _newsRepository;
        private readonly IMapper _mapper;

        public NewsServices(IRepository<News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await _newsRepository.Delete(id);
            await _newsRepository.Save();
           
        }
        public async Task Insert(News model)
        {
            await _newsRepository.Insert(model);
            await _newsRepository.Save();
        }
        public async Task<NewsDto> Get(int id)
        {
            return _mapper.Map<NewsDto>(await _newsRepository.GetById(id));
              //  (News)await _newsRepository.GetById(id);
        }

        public async Task<List<NewsDto>> GetAll()
        {
            return _mapper.Map<List<NewsDto>>(await _newsRepository.GetAll());
                 
        }

        public async Task Update(News news)
        {
            await _newsRepository.UpDate(news);
            await _newsRepository.Save();
        }
    }
}
