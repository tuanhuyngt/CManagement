using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group2.AbpZeroTemplate.Application.Share.Group2.Dto;
using Group2.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group2Controller : AbpController
  {
    private readonly IGroup2AppService Group2AppService;

    public Group2Controller(IGroup2AppService Group2AppService)
    {
      this.Group2AppService = Group2AppService;
    }
    
    [HttpGet]
    public string test()
    {
        return Group2AppService.test();
    }
  }
}
