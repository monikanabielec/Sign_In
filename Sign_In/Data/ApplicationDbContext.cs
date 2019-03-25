using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sign_In.Models;

namespace Sign_In.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet <Student> Students { get; set; }
        public DbSet <Subject> Subjects { get; set; }

       

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Subject>().HasData(
        //        new Subject
        //        {
                 
        //            SubjectId = 1,
        //            SubjectName = "C#",
        //            TeacherName = "Nowak Jan",
        //        },
        //        new Subject
        //        {
                  
        //            SubjectId = 2,
        //            SubjectName = "Java",
        //            TeacherName = "Kowalski Marek",
        //        }
        //        );
        //}
    }

   
}
