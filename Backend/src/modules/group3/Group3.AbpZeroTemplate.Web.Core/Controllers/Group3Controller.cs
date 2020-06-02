using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group3.AbpZeroTemplate.Application.Share.Group3.Dto;
using Group3.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group3Controller : AbpController
  {
    private readonly IGroup3AppService Group3AppService;

    public Group3Controller(IGroup3AppService Group3AppService)
    {
      this.Group3AppService = Group3AppService;
    }
    
    [HttpGet]
    public string test()
    {
        return Group3AppService.test();
    }
  }
}
