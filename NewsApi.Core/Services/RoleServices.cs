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
    public class RoleServices : IRoleServices
    {
        public readonly IRepository<Role> _roleRepository;
        public readonly IMapper _mapper;
        public RoleServices(IRepository<Role> roleRepository, IMapper mapper )
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task Delete(int Id)
        {
            await _roleRepository.Delete(Id);
            await _roleRepository.Save();
           
        }

        public async Task<RoleDto> Get(int Id)
        {
            return _mapper.Map<RoleDto>(await _roleRepository.GetById(Id));
        }

        public async Task<List<RoleDto>> GetAll()
        {
           return _mapper.Map<List<RoleDto>>(await _roleRepository.GetAll());
        }

        public async Task Insert(Role model)
        {
           await _roleRepository.Insert(model);
            await _roleRepository.Save();   
        }

        public async Task Update(Role model)
        {
            await _roleRepository.UpDate(model);
            await _roleRepository.Save();
        }
    }
}
