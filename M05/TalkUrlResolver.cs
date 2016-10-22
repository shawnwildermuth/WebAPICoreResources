using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using MyCodeCamp.Data.Entities;
using MyCodeCamp.Models;

namespace MyCodeCamp.Mapping
{
  public class TalkUrlResolver : UrlResolver<Talk, TalkModel>
  {
    public TalkUrlResolver(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
    {
    }

    public override string Resolve(Talk source, TalkModel destination, string destMember, ResolutionContext context)
    {
      return _urlHelper.Link("GetTalk", new { campId = source.Speaker.Camp.Id, speakerId = source.Speaker.Id, id = source.Id });
    }
  }
}
