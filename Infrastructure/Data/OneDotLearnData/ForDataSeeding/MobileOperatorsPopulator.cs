using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.ForDataSeeding
{
    internal class MobileOperatorsPopulator
    {
        internal static void Add(ModelBuilder modelBuilder)
        {
            var mOpId = 1;
            #region Algeria
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId,
                CountryId = 1,
                Code = 5,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 1,
                Code = 6,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 1,
                Code = 7,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Bahrain
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 2,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Botswana
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 3,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Burundi
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 4,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Cameroon
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 5,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Egypt
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 6,
                Code = 10,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 6,
                Code = 11,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 6,
                Code = 12,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 6,
                Code = 15,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Eritrea
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 7,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Eswatini
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 8,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Ethiopia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 9,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Gambia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 10,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Ghana
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 11,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Iraq
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 12,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Jordan
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 13,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Kenya
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 14,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Kuwait
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 15,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Lebanon
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 16,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Lesotho
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 17,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Liberia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 18,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Libya
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 19,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Malawi
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 20,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Mauritania
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 21,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Mauritius
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 22,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Morocco
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 23,
                Code = 6,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 23,
                Code = 7,
                NumberOfDigits = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Namibia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 24,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Nigeria
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 25,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Oman
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 26,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Qatar
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 27,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Rwanda
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 28,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Saudi Arabia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 29,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Seychelles
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 30,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Sierra Leone
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 31,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Somalia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 32,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region South Africa
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 33,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region South Sudan
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 34,
                Code = 91,
                NumberOfDigits = 7,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 34,
                Code = 92,
                NumberOfDigits = 7,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 34,
                Code = 95,
                NumberOfDigits = 7,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 34,
                Code = 97,
                NumberOfDigits = 7,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Sudan
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 35,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Tanzania
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 36,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Tunisia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 37,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Türkiye
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 38,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Uganda
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 39,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region UAE
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 40,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region USA
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 41,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Yemen
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 42,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Zambia
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 43,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
            #region Zimbabwe
            modelBuilder.Entity<MobileOperator>().HasData(new MobileOperator()
            {
                Id = mOpId++,
                CountryId = 44,
                Code = 91,
                NumberOfDigits = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active
            });
            #endregion
        }
    }
}
