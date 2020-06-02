using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group5.AbpZeroTemplate.Application.Share.Group5.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;

namespace Group5.AbpZeroTemplate.Web.Core.Cars
{
  public interface IGroup5AppService : IApplicationService
  {
    string test();
  }
  public class Group5AppService : BaseService, IGroup5AppService
  {
    public Group5AppService()
    {

    }
    public string test()
    {
      return "Group5 Config success!";
    }
  }
}
