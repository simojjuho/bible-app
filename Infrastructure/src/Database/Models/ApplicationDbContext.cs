using Core.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) :DbContext
{
   //the models for the database the application will use 
   
}