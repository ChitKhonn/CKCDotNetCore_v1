using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using CKCDotNetCore.ConsoleApp.Model;

namespace CKCDotNetCore.RestApi
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
 