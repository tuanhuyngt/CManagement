using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group5.AbpZeroTemplate.Application.Share.Group5.Dto;
using Group5.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group5Controller : AbpController
  {
    private readonly IGroup5AppService Group5AppService;

    public Group5Controller(IGroup5AppService Group5AppService)
    {
      this.Group5AppService = Group5AppService;
    }

    [HttpGet]
    public string test()
    {
      return Group5AppService.test();
    }
  }
}
