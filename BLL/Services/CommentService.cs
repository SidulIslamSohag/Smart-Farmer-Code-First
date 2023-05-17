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
    public class CommentService
    {
        public static CommentDTO AddComment(CommentDTO comment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CommentDTO, Comment>();
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Comment>(comment);
            var rt = DataAccessFactory.CommentAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<CommentDTO>(rt);
            }
            return null;
        }
        public static List<CommentDTO> Get()
        {
            var data = DataAccessFactory.CommentAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CommentDTO>>(data);
        }
        public static CommentDTO Get(int id)
        {
            var data = DataAccessFactory.CommentAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CommentDTO>(data);
        }
        public static CommentDTO Delete(int id)
        {
            var rt = DataAccessFactory.CommentAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Comment, CommentDTO>();
                });
                var mapper = new Mapper(config);
                var dbcomment = mapper.Map<CommentDTO>(rt);
                return dbcomment;
            }
            return null;
        }
        public static CommentDTO Update(CommentDTO comment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommentDTO, Comment>();
                cfg.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(config);
            var dbcomment = mapper.Map<Comment>(comment);
            var rt = DataAccessFactory.CommentAccess().Update(dbcomment);
            if (rt != null)
            {
                return mapper.Map<CommentDTO>(rt);
            }
            return null;
        }
    }
}
