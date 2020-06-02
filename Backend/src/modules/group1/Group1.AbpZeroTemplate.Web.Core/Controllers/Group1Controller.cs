using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Group1.AbpZeroTemplate.Application.Share.Group1.Dto;
using Group1.AbpZeroTemplate.Web.Core.Cars;
using GSoft.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1.AbpZeroTemplate.Application.Controllers
{
  [Route("api/[controller]/[action]")]
  public class Group1Controller : AbpController
  {
    private readonly IGroup1AppService group1AppService;

    public Group1Controller(IGroup1AppService group1AppService)
    {
      this.group1AppService = group1AppService;
    }
    
    [HttpGet]
    public string test()
    {
        return group1AppService.test();
    }
  }
}
