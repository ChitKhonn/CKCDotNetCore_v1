using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDotNetCore.ConsoleApp.Model;

namespace TestingDotNetCore.ConsoleApp.EFCoreExamples
{
    public class AppDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = "CKC\\SQLEXPRESS",
                InitialCatalog = "CKCDotNetCore",
                UserID = "sa",
                Password = "asd123!@#",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(builder.ConnectionString);
        }
        public DbSet<BlogDataModel> Blogs { get; set; }
    } 
}
 