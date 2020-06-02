using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group6.AbpZeroTemplate.Application.Share.Group6.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;

namespace Group6.AbpZeroTemplate.Web.Core.Cars
{
  public interface IGroup6AppService : IApplicationService
  {
    string test();
  }
  public class Group6AppService : BaseService, IGroup6AppService
  {
    public Group6AppService()
    {

    }
    public string test()
    {
      return "Group6 Config success!";
    }
  }
}
