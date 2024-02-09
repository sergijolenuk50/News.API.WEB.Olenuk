using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Infrastructure.Initializers
{
    internal static class AppDbInitializer
    {
        public static async Task SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
                { 
                    new Category() { Id = 1, Name = "Sport" , Description = "Category about sport" },
                    new Category() { Id = 2, Name = "Cience" , Description = "Category about cience" }
                }
            );
        }

        public static async Task SeedNews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(new News[]
                {
        
                    new News() { Id = 1, Name = "New Kyiv" , CategoryId = 1, Information = "There is no time to hesitate", AuthorId = 1, CountNewsOpen = 2},
                    new News() { Id = 2, Name = "New Kyiv" , CategoryId = 1, Information = "Freud's conditioning", AuthorId = 2, CountNewsOpen = 0 },
                    new News() { Id = 3, Name = "Sport Kyiv" , CategoryId = 2, Information = "Rebrov recently received an offer to head the club", AuthorId = 2, CountNewsOpen= 0 }

                }
            );
        }

        public static async Task SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
                {

                    new Author() { Id = 1, Name = "Sara" , Surname = "Ivanova", City = "Kyiv" , Email ="sara@ua", NewsId = 1 },
                    new Author() { Id = 2, Name = "Dima" , Surname = "Dallas", City = "Kyiv" , Email ="dima@ua", NewsId = 2 },
                    new Author() { Id = 3, Name = "Ira" , Surname = "Dmitrivna", City = "Kyiv" , Email ="ira@ua", NewsId = 3 }

                }
            );
        }

        public static async Task SeedStatistics(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistics>().HasData(new Statistics[]
            {
                new Statistics() { Id = 1, IP="127.127.000.255", BrowserName = "Chrome", OS = "Windows", Cyti = "Rivne" , NewsId= 1 },
                new Statistics() { Id = 2, IP="127.127.000.285", BrowserName = "Mazila", OS = "Windows", Cyti = "Kyiv", NewsId= 1 }

            }
             );
        }

        public static async Task SeedRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role[]
            {
            new Role(){ Id = 1, RoleName = "Redactor"  },
            new Role(){ Id = 2, RoleName = "Admin"  },
            new Role(){ Id = 3, RoleName = "Writer"  }
            });
        }

        public static async Task SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users[]
            {
            new Users() { Id =1, FirstName = "Sars", LastName ="Ivanova", Email = "sa@gmail.com", Password ="123", RoleId = 1},
            new Users() { Id =2, FirstName = "Dima", LastName ="Sergiovich", Email = "dimas@gmail.com", Password ="121", RoleId = 2},
            new Users() { Id =3, FirstName = "Isaak", LastName ="Dmitrovich", Email = "isa@gmail.com", Password ="223", RoleId = 3},
            new Users() { Id =4, FirstName = "Ira", LastName ="Iackivna", Email = "ira@gmail.com", Password ="111", RoleId = 3},

            });
        }
    }
}
