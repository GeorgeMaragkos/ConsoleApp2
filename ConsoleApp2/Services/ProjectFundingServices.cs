﻿using ConsoleApp2.DbContexts;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class ProjectFundingServices: IServices
    {
        private readonly OurDbContext _ourDbContext;


        public ProjectFundingServices(OurDbContext ourDbContext)
        {
            _ourDbContext = ourDbContext;
        }

        public void Create()
        {
            var projectFunding = new ProjectFunding(); //this is needed to be dynamic from the forms

            _ourDbContext.ProjectFundings.Add(projectFunding);
            _ourDbContext.SaveChanges();
        }

        public void Delete() // this will need a change for the final version
        {
            int projectFundingId = 5; //this is needed to be dynamic from the forms
            var projectFunding = _ourDbContext
                .ProjectFundings
                .Where(p => p.Id == projectFundingId)
                .FirstOrDefault();
            if (projectFunding != null)
            {
                _ourDbContext.ProjectFundings.Remove(projectFunding);
                _ourDbContext.SaveChanges();
            }

        }

        public void Read()
        {

            List<ProjectFunding> projectFundings = _ourDbContext.ProjectFundings.ToList();

            projectFundings.ForEach(projectFundings =>
            { Console.WriteLine($" projectFundings.Id = {projectFundings.Id}"); });  // this will need a change for the final version

        }

        public void Update() // this will need a change for the final version
        {
            int projectFundingId = 5; //this is needed to be dynamic from the forms
            string newDescription = "Project Funding"; //this is needed to be dynamic from the forms

            var projectFunding = _ourDbContext
                .ProjectFundings
                .Where(p => p.Id == projectFundingId)
                .FirstOrDefault();
            if (projectFunding != null)
            {
                projectFunding.Description = newDescription;
                _ourDbContext.SaveChanges();
            }

        }
    }
}
