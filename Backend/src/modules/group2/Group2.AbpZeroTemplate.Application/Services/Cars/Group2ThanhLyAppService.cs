using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using GSoft.AbpZeroTemplate.Helpers;
using GSoft.AbpZeroTemplate.Sessions;
using Group2.AbpZeroTemplate.Application.Share.Group2.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using GSoft.AbpZeroTemplate.Sessions;
using GSoft.AbpZeroTemplate.Sessions.Dto;

namespace Group2.AbpZeroTemplate.Web.Core.Cars
{
    public interface IGroup2ThanhLyAppService : IApplicationService
    {
        List<Group2ThanhLyDto> THANHLY_Group2Search(Group2ThanhLyDto input);
        IDictionary<string, object> THANHLY_Group2Ins(Group2ThanhLyDto input);
        IDictionary<string, object> THANHLY_Group2UpdateTrangThai(int thanhLy_MaXe);
        string test();

    }
    public class Group2ThanhLyAppService : BaseService, IGroup2ThanhLyAppService
    {
        public Group2ThanhLyAppService()
        {
       
        }
        public List<Group2ThanhLyDto> THANHLY_Group2Search(Group2ThanhLyDto input)
        {
            return procedureHelper.GetData<Group2ThanhLyDto>("THANHLY_Group2Search", input);
        }
        public IDictionary<string, object> THANHLY_Group2Ins(Group2ThanhLyDto input)
        {
            return procedureHelper.GetData<dynamic>("THANHLY_Group2Ins", input).FirstOrDefault();
        }
        public IDictionary<string, object> THANHLY_Group2UpdateTrangThai(int thanhLy_MaXe)
        {
            return procedureHelper.GetData<dynamic>("THANHLY_Group2UpdateTrangThai", new {ThanhLy_MaXe = thanhLy_MaXe}).FirstOrDefault();
        }

        public string test()
        {
            return "Group2 Config success!";
        }
    }
}
