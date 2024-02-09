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
    public class UsersServices : IUsersServices
    {
       // private readonly IRepository<Users> _newsRepository;
       private readonly IRepository<Users> _usersRepository;
        public readonly IMapper _mapper;
      
       public UsersServices(IRepository<Users> usersRepository, IMapper mapper)
       {
           _usersRepository = usersRepository;
            _mapper = mapper;
       }
      
       public async Task Delete(int id)
       {
           await _usersRepository.Delete(id);
           await _usersRepository.Save();
       }
      
       public async Task<UsersDto> Get(int id)
       {
           return _mapper.Map<UsersDto>(await _usersRepository.GetById(id));
       }
      
       public async Task<List<UsersDto>> GetAll()
       {
          return _mapper.Map<List<UsersDto>>(await _usersRepository.GetAll());
       }
      
       public async Task Insert(Users model)
       {
           await _usersRepository.Insert(model);
           await _usersRepository.Save();
       }
      
       public async Task Update(Users model)
       {
           await _usersRepository.UpDate(model);
       }
    }
}
