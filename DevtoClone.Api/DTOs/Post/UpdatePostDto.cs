﻿namespace DevtoClone.Api.DTOs.Post
{
    public class UpdatePostDto
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public Guid UserId { get; set; }
        public string[] PostTags { get; set; } = null!;
    }
}
