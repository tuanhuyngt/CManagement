using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group7.AbpZeroTemplate.Application.Share.Group7.Dto;
using Group7.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group7Controller : AbpController
  {
    private readonly IGroup7AppService Group7AppService;

    public Group7Controller(IGroup7AppService Group7AppService)
    {
      this.Group7AppService = Group7AppService;
    }
    
    [HttpGet]
    public string test()
    {
        return Group7AppService.test();
    }
  }
}
