﻿using BLL.MapperBLL;
using BLL.Models;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService
    {
        private readonly ProjectRepository _projectRepository;
        public ProjectService(ProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }



        public ProjectBLL GetOne(int Id)
        {
            //return _projectRepository.GetOne(Id).ToApi();
            return null;
        }

        public ProjectBLL Create(string nameProject)
        {
            //return _projectRepository.Create(nameProject).ToApi();
            return null;
        }

        public IEnumerable<ProjectBLL> GetAll()
        {
            //return _projectRepository.GetAll().Select(p => p.ToApi());
            return null;

        }

        public void Update(ProjectEntity project)
        {

            //_projectRepository.Update(project);
            //return null;
        }
    }
}
