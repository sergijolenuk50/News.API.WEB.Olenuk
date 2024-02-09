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
    public class StatisticsServices : IStatisticsServices
    {
        private readonly IRepository<Statistics> _statisticsRepository;
        private readonly IMapper _mapper;
        public StatisticsServices(IRepository<Statistics> statisticsRepository, IMapper mapper)
        {
            _statisticsRepository = statisticsRepository;
            _mapper = mapper;
        }
        public async Task Delete(int Id)
        {
           await _statisticsRepository.Delete(Id);
        }

        public async Task<Statistics> Get(int Id)
        {
            return _mapper.Map<Statistics>(await _statisticsRepository.GetById(Id));
                
             
        }

        public async Task<List<Statistics>> GetAll()
        {
            return _mapper.Map<List<Statistics>>(await _statisticsRepository.GetAll());
               
        }

        public async Task Insert(Statistics author)
        {
            await _statisticsRepository.Insert(author);
            await _statisticsRepository.Save();
        }

        public async Task Update(Statistics author)
        {
            await _statisticsRepository.UpDate(author);
            await _statisticsRepository.Save();
        }
    }
}
