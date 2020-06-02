using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group4.AbpZeroTemplate.Application.Share.Group4.Dto;
using Group4.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group4Controller : AbpController
  {
    private readonly IGroup4AppService Group4AppService;

    public Group4Controller(IGroup4AppService Group4AppService)
    {
      this.Group4AppService = Group4AppService;
    }
    
    [HttpGet]
    public string test()
    {
        return Group4AppService.test();
    }
  }
}
