using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static UserDTO AddCustomer(UserDTO user)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<User>(user);
            var rt = DataAccessFactory.UserAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<UserDTO>(rt);
            }
            return null;
        }
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<UserDTO>>(data);
        }
        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<UserDTO>(data);
        }
        public static UserDTO Delete(int id)
        {
            var rt = DataAccessFactory.UserAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<User, UserDTO>();
                });
                var mapper = new Mapper(config);
                var dbuser = mapper.Map<UserDTO>(rt);
                return dbuser;
            }
            return null;
        }
        public static UserDTO Update(UserDTO user)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var dbuser = mapper.Map<User>(user);
            var rt = DataAccessFactory.UserAccess().Update(dbuser);
            if (rt != null)
            {
                return mapper.Map<UserDTO>(rt);
            }
            return null;
        }
    }
}
