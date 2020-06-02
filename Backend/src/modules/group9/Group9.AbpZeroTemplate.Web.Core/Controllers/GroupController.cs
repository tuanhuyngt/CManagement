using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group9.AbpZeroTemplate.Application.Share.Group9.Dto;
using Group9.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group9Controller : AbpController
  {
    private readonly IGroup9AppService Group9AppService;

    public Group9Controller(IGroup9AppService Group9AppService)
    {
      this.Group9AppService = Group9AppService;
    }

    [HttpGet]
    public string test()
    {
      return Group9AppService.test();
    }
  }
}
