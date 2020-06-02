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
    public class Group2ThanhLyController : AbpController
    {
        private readonly IGroup2ThanhLyAppService Group2ThanhLyAppService;

        public Group2ThanhLyController(IGroup2ThanhLyAppService Group2ThanhLyAppService)
        {
            this.Group2ThanhLyAppService = Group2ThanhLyAppService;
        }
    
        [HttpGet]
        public string test()
        {
            return Group2ThanhLyAppService.test();
        }
        [HttpPost]
        public List<Group2ThanhLyDto> THANHLY_Group2Search([FromBody]Group2ThanhLyDto input)
        {
            return Group2ThanhLyAppService.THANHLY_Group2Search(input);
        }
        [HttpPost]
        public IDictionary<string, object> THANHLY_Group2Ins([FromBody]Group2ThanhLyDto input)
        {
            return Group2ThanhLyAppService.THANHLY_Group2Ins(input);
        }
        [HttpPost]
        public IDictionary<string, object> THANHLY_Group2UpdateThanhLy(int thanhLy_MaXe)
        {
            return Group2ThanhLyAppService.THANHLY_Group2UpdateTrangThai(thanhLy_MaXe);
        }
    }
}
