using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewDemoInvoiceApplication.Model;
using NewDemoInvoiceApplication.Repository.Interface;

namespace NewDemoInvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonDropdownController : ControllerBase
    {
        private readonly ICommonDropdownAsyncRepository commonDropdownAsync;
        public CommonDropdownController(ICommonDropdownAsyncRepository commonDropdownAsync)
        {
            this.commonDropdownAsync = commonDropdownAsync;
        }
        [HttpGet("GetAllInvoiceDropdown")]
        public async Task<IActionResult> GetAllInvoice()
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await commonDropdownAsync.GetInvoiceDropdown();
                if (result != null)
                {
                    baseResponse.SuccessMessage = $"Common invoice dropdown records fetch successfully...!";
                    baseResponse.ResponseData = result;
                    return Ok(baseResponse);
                }
                else
                {
                    baseResponse.ErrorMessage = "there is no records";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
        [HttpGet("GetItemDropdown")]
        public async Task<IActionResult> GetItemDropdown()
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await commonDropdownAsync.GetItemDropdown();
                if (result != null)
                {
                    baseResponse.SuccessMessage = $"Common item dropdown records fetch successfully...!";
                    baseResponse.ResponseData = result;
                    return Ok(baseResponse);
                }
                else
                {
                    baseResponse.ErrorMessage = "there is no records";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
    }
}
