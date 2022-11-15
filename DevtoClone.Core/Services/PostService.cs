using Azure;
using DevtoClone.Core.Interfaces;
using DevtoClone.Entities.Models;
using DevtoClone.Entities.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Core.Services
{
    public class PostService : IPostService
    {
        private readonly ILogger<PostService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PostService(ILogger<PostService> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        private async Task<IEnumerable<Tag>> GetTagsAsync(string[] postTags)
        {
            var existingTags = await _unitOfWork.Tags.GetAsync(filter: x => postTags.Any(t => t == x.Name));
            var newTags = postTags.Where(t => existingTags.Any(et => et.Name != t)).Select(tag => new Tag { Name = tag });

            if(newTags.Any())
            {
                _unitOfWork.Tags.AddRange(newTags);
                await _unitOfWork.SaveAsync();
            }

            return existingTags.Concat(newTags);
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            try
            {
                return await _unitOfWork.Posts.GetAsync(includeProperties: "User,Tags");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Post> GetPostById(Guid id)
        {
            try
            {
                var post = (await _unitOfWork.Posts.GetAsync(filter: p => p.Id == id, includeProperties: "User,Tags"))
                    .FirstOrDefault();

                if (post is null)
                {
                    throw new ArgumentNullException(nameof(post));
                }

                return post;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task CreatePost(Post post, string[] postTags)
        {
            try
            {
                if(postTags.Any())
                {
                    var tags = await GetTagsAsync(postTags);

                    post.Tags = new Collection<Tag>();
                    foreach (var tag in tags)
                    {
                        post.Tags.Add(tag);
                    }
                }

                _unitOfWork.Posts.Add(post);
                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdatePost(Guid id, Post post, string[] postTags)
        {
            try
            {
                var existingPost = await _unitOfWork.Posts.GetByIdAsync(id);

                if (existingPost is null)
                {
                    throw new ArgumentNullException(nameof(existingPost));
                }

                if (postTags.Any())
                {
                    var tags = await GetTagsAsync(postTags);
                    foreach (var tag in tags)
                    {
                        post.Tags.Add(tag);
                    }
                }

                existingPost.Title = post.Title;
                existingPost.Content = post.Content;

                _unitOfWork.Posts.Update(existingPost);
                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeletePost(Guid id)
        {
            try
            {
                var existingPost = await _unitOfWork.Posts.GetByIdAsync(id);

                if (existingPost is null)
                {
                    throw new ArgumentNullException(nameof(existingPost));
                }

                _unitOfWork.Posts.Delete(existingPost);
                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
