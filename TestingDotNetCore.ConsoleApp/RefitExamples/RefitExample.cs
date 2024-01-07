using CKCDotNetCore.ConsoleApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CKCDotNetCore.ConsoleApp.RefitExamples
{
    public class RefitExample
    {

        private readonly IBlogApi _blogApi = RestService.For<IBlogApi>("https://localhost:7185");

        public async Task Run()
        {
            /*await Read();
            await Edit(1);*/
            //await Create("Test Title Data", "Test Author Data", "Test Content Data");
            //await Update(2, "Title edited", "Author edited", "Content edited");
            //await Delete(1);

        }

        public async Task Read()
        {
            var lst = await _blogApi.GetBlogs();
            foreach (BlogDataModel item in lst)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
        }

        public async Task Edit(int id)
        {

            try
            {
                var lst = await _blogApi.GetBlog(id);

                Console.WriteLine(lst.Blog_Id);
                Console.WriteLine(lst.Blog_Title);
                Console.WriteLine(lst.Blog_Author);
                Console.WriteLine(lst.Blog_Content);
            }
            /*catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }*/
            catch (ApiException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ReasonPhrase);
            }


        }

        public async Task Create(string title, string author, string content)
        {
             var message = await _blogApi.CreateBlog(new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            });

            await Console.Out.WriteLineAsync(message);
        }

        public async Task Update(int id, string title, string author, string content)
        {
            try
            {
                string message = await _blogApi.PutBlog(id, new BlogDataModel
                {
                    Blog_Id = id,
                    Blog_Title = title,
                    Blog_Author = author,
                    Blog_Content = content
                });
                await Console.Out.WriteLineAsync(message);
            }
            catch (ApiException ex)
            {
                await Console.Out.WriteLineAsync(ex.ToString());
            }
        }

        public async Task PatchBlog(int id, string title)
        {
            try
            {
                string message = await _blogApi.PatchBlog(id, new BlogDataModel
                {
                    Blog_Title = title,
                });
                await Console.Out.WriteLineAsync(message);
            }
            catch (ApiException ex)
            {
                await Console.Out.WriteLineAsync(ex.ToString());
            }
        }
  
        public async Task Delete(int id)
        {
            try
            {
                string message = await _blogApi.DeleteBlog(id);
                await Console.Out.WriteLineAsync(message);
            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex.ReasonPhrase!.ToString());
            }
        }

    }
}
