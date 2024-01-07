using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Add;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Add;

public class AddBlogPostCommandRequest : IRequest<AddBlogPostCommandResponse>
{
    public string Title {  get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
    
   // public AppUser AppUser { get; set; }// user eklendiğinde o an aktif olan user'ı atarız
   
  

}
