using AutoMapper;
using DevtoClone.Api.DTOs.Post;
using DevtoClone.Api.Mapper;
using DevtoClone.Core.Interfaces;
using DevtoClone.Core.Services;
using DevtoClone.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevtoClone.Api.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : Controller
    {
        //private IMapper _mapper;
        //private IPostService _postService;

        //public PostController(IMapper mapper, IPostService postService)
        //{
        //    _mapper = mapper;
        //    _postService = postService;
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAllPosts()
        //{
        //    var posts = await _postService.GetAllPosts();

        //    var postsDto = _mapper.MapPosts(posts);

        //    return Ok(postsDto);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetPostById(Guid id)
        //{
        //    var post = await _postService.GetPostById(id);

        //    var postDto = _mapper.Map<PostDto>(post);

        //    return Ok(postDto);
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreatePost([FromBody] CreatePostDto postDto)
        //{
        //    var post = _mapper.Map<Post>(postDto);

        //    await _postService.CreatePost(post);

        //    return NoContent();
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdatePost(Guid id, [FromBody] UpdatePostDto postDto)
        //{
        //    var post = _mapper.Map<Post>(postDto);

        //    await _postService.UpdatePost(id, post);

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePost(Guid id)
        //{
        //    await _postService.DeletePost(id);

        //    return NoContent();
        //}
    }
}
