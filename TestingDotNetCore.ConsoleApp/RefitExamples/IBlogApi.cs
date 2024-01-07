using CKCDotNetCore.ConsoleApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKCDotNetCore.ConsoleApp.RefitExamples
{
    public interface IBlogApi
    {
        [Get("/api/blog")]
        Task<List<BlogDataModel>> GetBlogs();

        [Get("/api/blog/{id}")]
        Task<BlogDataModel> GetBlog(int id);

        [Post("/api/blog}")]
        Task<string> CreateBlog(BlogDataModel blog);
 
        [Put("/api/blog/{id}")]
        Task<string> PutBlog(int id, BlogDataModel blog);

        [Patch("/api/blog/{id}")]
        Task<string> PatchBlog(int id, BlogDataModel blog);

        [Delete("/api/blog/{id}")]
        Task<string> DeleteBlog(int id);

    }
}
