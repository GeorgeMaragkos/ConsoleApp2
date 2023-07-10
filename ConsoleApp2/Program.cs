using ConsoleApp2.DbContexts;
using ConsoleApp2.Models;
using ConsoleApp2.Services;

using var DbContext = new OurDbContext();

var projectServices = new ProjectServices(DbContext);




