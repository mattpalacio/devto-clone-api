using DevtoClone.Core.Interfaces;
using DevtoClone.Entities.Models;
using DevtoClone.Entities.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Core.Services
{
    public class PostService : IPostService
    {
        private ILogger<PostService> _logger;
        private IUnitOfWork _unitOfWork;

        public PostService(ILogger<PostService> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //public Task<IEnumerable<Post>> GetAllPosts()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Post> GetPostById(Guid id)
        {
            try
            {
                var post = await _unitOfWork.Posts.GetByIdAsync(id);

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

        public async Task CreatePost(Post post, string[] tags)
        {
            try
            {
                if(tags.Any())
                {
                    post.Tags = (ICollection<Tag>)(IEnumerable<Tag>)tags.Select(async tag =>
                    {
                        var existingTag = (await _unitOfWork.Tags.GetAsync(filter: t => t.Name == tag)).FirstOrDefault();

                        if (existingTag is null)
                        {
                            var newTag = new Tag
                            {
                                Name = tag
                            };

                            _unitOfWork.Tags.Add(newTag);

                            return newTag;
                        }

                        return existingTag;
                    });
                }

                _unitOfWork.Posts.Add(post);

                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdatePost(Guid id, Post post, string[] tags)
        {
            try
            {
                var existingPost = await _unitOfWork.Posts.GetByIdAsync(id);

                if (existingPost is null)
                {
                    throw new ArgumentNullException(nameof(existingPost));
                }

                if (tags.Any())
                {
                    existingPost.Tags = (ICollection<Tag>)(IEnumerable<Tag>)tags.Select(async tag =>
                    {
                        var existingTag = (await _unitOfWork.Tags.GetAsync(filter: t => t.Name == tag)).FirstOrDefault();

                        if (existingTag is null)
                        {
                            var newTag = new Tag
                            {
                                Name = tag
                            };

                            _unitOfWork.Tags.Add(newTag);

                            return newTag;
                        }

                        return existingTag;
                    });
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
                _unitOfWork.Posts.Delete(id);

                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
