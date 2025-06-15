using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.ForDataSeeding
{
    internal class FinAccountsPopulator
    {
        internal static void Add(ModelBuilder modelBuilder)
        {
            int accId = 1;
            modelBuilder.Entity<Account>().HasData(new Account() // 1
            {
                Id = accId++,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Assets",
                Number = 1000,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 2
            {
                Id = accId++,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Liabilities,
                AccountSide = AccountSide.Credit,
                Name = "Liabilities",
                Number = 2000,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 3
            {
                Id = accId++,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Equity,
                AccountSide = AccountSide.Credit,
                Name = "Equity",
                Number = 3000,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 4
            {
                Id = accId++,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Revenues",
                Number = 4000,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 5
            {
                Id = accId++,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Expenses,
                AccountSide = AccountSide.Debit,
                Name = "Expenses",
                Number = 5000,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 6
            {
                Id = accId++,
                ParentId = 1,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Cash",
                Number = 1010,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 7
            {
                Id = accId++,
                ParentId = 7,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Bank Account - OneDotSoft AlBaraka Turkish Lira",
                Number = 10101,
                CurrencyId = 18,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 8
            {
                Id = accId++,
                ParentId = 7,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Bank Account - OneDotSoft AlBaraka US Dollar",
                Number = 10102,
                CurrencyId = 19,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 9
            {
                Id = accId++,
                ParentId = 1,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Accounts Receivable",
                Number = 1060,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 10
            {
                Id = accId++,
                ParentId = 9,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Assets,
                AccountSide = AccountSide.Debit,
                Name = "Customers",
                Number = 10601,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 11
            {
                Id = accId++,
                ParentId = 2,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Liabilities,
                AccountSide = AccountSide.Credit,
                Name = "Accounts Payable",
                Number = 2010,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 12
            {
                Id = accId++,
                ParentId = 11,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Liabilities,
                AccountSide = AccountSide.Credit,
                Name = "Instructors",
                Number = 20101,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 13
            {
                Id = accId++,
                ParentId = 4,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Sales",
                Number = 4010,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 14
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Courses",
                Number = 40101,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 15
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Software Development",
                Number = 40102,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 16
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Company,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Consultations",
                Number = 40103,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 17
            {
                Id = accId++,
                ParentId = 14,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "C Programming Fundamentals",
                Number = 40101001,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 18
            {
                Id = accId++,
                ParentId = 14,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "C++ Programming Fundamentals",
                Number = 40101002,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 19
            {
                Id = accId++,
                ParentId = 14,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Java 17 Programming Fundamentals (Desktop)",
                Number = 40101003,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 20
            {
                Id = accId++,
                ParentId = 14,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced Java 17 Programming",
                Number = 40101004,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 21
            {
                Id = accId++,
                ParentId = 14,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "C# 10 Programming Fundamentals (Desktop)",
                Number = 40101005,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 22
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced C# 10 Programming",
                Number = 40101006,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 23
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Developing Web Applications Using ASP.NET Core with C#",
                Number = 40101007,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 24
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced Web Applications Development Using ASP.NET Core with C#",
                Number = 40101008,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 25
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Developing Web Applications Using PHP 8",
                Number = 40101009,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 26
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Developing Android Mobile Apps Using Java",
                Number = 40101010,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 27
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced Android Mobile Applications Development Using Java",
                Number = 40101011,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 28
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Developing Android Mobile Apps Using Xamarin Forms with C#",
                Number = 40101012,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 29
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced Android Mobile Applications Development Using Xamarin Forms with C#",
                Number = 40101013,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 30
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Introduction to Games Programming Using Unity and C#",
                Number = 40101014,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 31
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "PhotoShop Fundamentals",
                Number = 40101015,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 32
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Advanced Graphic Design",
                Number = 40101016,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 33
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Animation Fundamentals Using Adobe After Effects",
                Number = 40101017,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 34
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Web Design Fundamentals",
                Number = 40101018,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 35
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "MATLAB Fundamentals",
                Number = 40101019,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 36
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Introduction to AutoCAD",
                Number = 40101020,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 37
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Introduction to Data Science Using Python",
                Number = 40101021,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 38
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Machine Learning Fundamentals",
                Number = 40101022,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() // 39
            {
                Id = accId++,
                ParentId = 13,
                OwnerType = OwnerType.Course,
                AccountType = AccountType.Revenues,
                AccountSide = AccountSide.Credit,
                Name = "Start Your Small Business",
                Number = 40101023,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Account>().HasData(new Account() //40
            {
                Id = accId++,
                ParentId = 12,
                OwnerType = OwnerType.Instructor,
                AccountType = AccountType.Liabilities,
                AccountSide = AccountSide.Credit,
                Name = "Waleed AlGhadamsy",
                Number = 20101001,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
        }

    }
}
