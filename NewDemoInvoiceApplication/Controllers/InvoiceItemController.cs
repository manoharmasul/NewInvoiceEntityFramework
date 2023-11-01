using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewDemoInvoiceApplication.Model;
using NewDemoInvoiceApplication.Repository.Interface;

namespace NewDemoInvoiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IInvoiceAsycRepositoryAsync invoiceAsyc;
        public InvoiceItemController(IInvoiceAsycRepositoryAsync invoiceAsyc)
        {
            this.invoiceAsyc = invoiceAsyc;
        }
        [HttpPost("AddNewInvoiceItem")]
        public async Task<IActionResult> AddNewInvoiceItem(InvoiceItem item)
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await invoiceAsyc.AddInvoiceData(item);
                if (result > 0)
                {
                    baseResponse.SuccessMessage = $"Invoice item added successfully...!";
                    baseResponse.ResponseData = result;
                    return Ok(baseResponse);
                }
                else
                {
                    baseResponse.ErrorMessage = "Invoice item not added something is wrong...!";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
        [HttpPut("UpdateInvoiceItem")]
        public async Task<IActionResult> UpdateInvoiceItem(InvoiceItem item)
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {

                var result = await invoiceAsyc.UpdateInvoiceData(item);
                if (result > 0)
                {
                    baseResponse.SuccessMessage = $"Invoice item udated successfully...!";
                    baseResponse.ResponseData = result;
                    return Ok(baseResponse);
                }
                else
                {
                    baseResponse.ErrorMessage = "Invoice item not updated something is wrong...!";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
        [HttpGet("GetAllInvoiceItem")]
        public async Task<IActionResult> GetAllInvoiceItem()
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await invoiceAsyc.GetInvoiceData();
                if (result.Count > 0)
                {
                    baseResponse.SuccessMessage = "Invoice data fetch successfull...!";
                    baseResponse.ResponseData = result;
                    return Ok(baseResponse);
                }
                else
                {
                    baseResponse.ErrorMessage = "There is no any record";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
        [HttpGet("GetInvoiceItemById")]
        public async Task<IActionResult> GetInvoiceItemByIinvoiceNo(int Id)
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await invoiceAsyc.GetInvoiceDataById(Id);
                if (result != null)
                {
                    baseResponse.SuccessMessage = "Invoice item data fetch successfull...!";
                    baseResponse.ResponseData = result;
                    return Ok(result);
                }
                else
                {
                    baseResponse.ErrorMessage = $"There is no data for invoice_no {invoice_no}";
                    return Ok(baseResponse);
                }
            }
            catch (Exception ex)
            {
                baseResponse.ErrorMessage = ex.Message;
                return Ok(baseResponse);
            }
        }
        [HttpDelete("InvoiceItemDelete")]
        public async Task<IActionResult> DeleteInvoiceItem(int Id)
        {
            BaseResponseModel baseResponse = new BaseResponseModel();
            try
            {
                var result = await invoiceAsyc.DeleteInvoiceData(Id);

                if (result > 0)
                {
                    baseResponse.SuccessMessage = "Invoice item is deleted successfully...!";
                    baseResponse.ResponseData = Id;
                    return Ok(result);
                }
                else
                {
                    baseResponse.SuccessMessage = "Invoice item not deleted soemthing is wrong...!";
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
