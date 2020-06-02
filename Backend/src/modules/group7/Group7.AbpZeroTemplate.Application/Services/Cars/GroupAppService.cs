using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group7.AbpZeroTemplate.Application.Share.Group7.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;

namespace Group7.AbpZeroTemplate.Web.Core.Cars
{
  public interface IGroup7AppService : IApplicationService
  {
        string test();
  }
  public class Group7AppService : BaseService, IGroup7AppService
    {
    public Group7AppService()
    {
       
    }
    public string test()
    {
        return "Group7 Config success!";
    }
  }
}
