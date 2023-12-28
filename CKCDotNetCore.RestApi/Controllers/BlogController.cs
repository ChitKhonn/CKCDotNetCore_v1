﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CKCDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetBlogs()
        {
            return Ok("get");
        }

        [HttpPost]
        public IActionResult CreateBlogs()
        {
            return Ok("post");
        }

        [HttpPut]
        public IActionResult UpdateBlogs()
        {
            return Ok("put");
        }

        [HttpPatch]
        public IActionResult PatchBlogs()
        {
            return Ok("patch");
        }

        [HttpDelete]
        public IActionResult DeleteBlogs()
        {
            return Ok("delete");
        }
    }
}