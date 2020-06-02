using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group10.AbpZeroTemplate.Application.Share.Group10.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;

namespace Group10.AbpZeroTemplate.Web.Core.Cars
{
  public interface IGroup10AppService : IApplicationService
  {
        string test();
  }
  public class Group10AppService : BaseService, IGroup10AppService
    {
    public Group10AppService()
    {
       
    }
    public string test()
    {
        return "Group10 Config success!";
    }
  }
}
