﻿using MediatR;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Add
{
    public class AddCommentCommandHandler : IRequestHandler<AddCommentCommandRequest, AddCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;

        public AddCommentCommandHandler(ICommentWriteRepository commentWriteRepository)
        {
            _commentWriteRepository = commentWriteRepository;
        }

        public async Task<AddCommentCommandResponse> Handle(AddCommentCommandRequest request, CancellationToken cancellationToken)
        {
            // Yorum ekleme işlemi
            var comment = new Comment
            {
                Content = request.Content,
                AppUserId = request.AppUserId,
                BlogPostId = request.BlogPostId,
                CreatedByUserId = "livos",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                IsDeleted = false
            };

            _commentWriteRepository.Add(comment);
            _commentWriteRepository.SaveChanges();

            // eklendiyse yanıt
            var response = new AddCommentCommandResponse
            {
                IsSuccess = comment.Id != Guid.Empty
            };

            return response;
        }


    }
}

