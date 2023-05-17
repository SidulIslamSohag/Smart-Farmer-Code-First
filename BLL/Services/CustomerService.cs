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
    public class CustomerService
    {
        public static CustomerDTO AddCustomer(CustomerDTO customer)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Customer>(customer);
            var rt = DataAccessFactory.CustomerAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<CustomerDTO>(rt);
            }
            return null;
        }
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CustomerDTO>>(data);
        }
        public static CustomerDTO Get(int id)
        {
            var data = DataAccessFactory.CustomerAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CustomerDTO>(data);
        }
        public static CustomerDTO Delete(int id)
        {
            var rt = DataAccessFactory.CustomerAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Customer, CustomerDTO>();
                });
                var mapper = new Mapper(config);
                var dbcustomer = mapper.Map<CustomerDTO>(rt);
                return dbcustomer;
            }
            return null;
        }
        public static CustomerDTO Update(CustomerDTO customer)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var dbcustomer = mapper.Map<Customer>(customer);
            var rt = DataAccessFactory.CustomerAccess().Update(dbcustomer);
            if (rt != null)
            {
                return mapper.Map<CustomerDTO>(rt);
            }
            return null;
        }
    }
}
