using MediatR;
using Microsoft.AspNetCore.Mvc;
using SstTekAPIQuiz.EmailMediator.CommandEmail;
using SstTekAPIQuiz.EmailMediator.GetEmail;
using SstTekAPIQuiz.Filters;
using SstTekAPIQuiz.Linq;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("email/{number}")]
        public async Task<JsonResult> GetMail(int id)
        {
            
            var mail = await _mediator.Send(id);
            var response = new ResponseModel
            {
                StatusCode = 200,
                Message = "Success",
                Data = mail
            };
            return new JsonResult(response);
        }
        [HttpGet]
        [Route("emails")]
        public async Task<JsonResult> GetEmails([FromQuery]GetAllEmailQuery request) 
        {
            var mailList = await _mediator.Send(request);
            var response = new ResponseModel
            {
                StatusCode = 200,
                Message = "Success",
                Data = mailList
            };
            return new JsonResult(response);
            
        }
        [HttpPost]
        [Route("email")]
        [EmailValidation]

        public async Task<JsonResult> CreateEmail([FromBody]CreateEmailRequest request)
        {
            var newEmail = await _mediator.Send(request);
            var response = new ResponseModel
            {
                StatusCode = 200,
                Message = "Success",
                Data = newEmail
            };
            return new JsonResult(response);
        }

        [HttpDelete]
        [Route("email/{number}")]
        public async Task<JsonResult> DeleteEmail([FromBody]DeleteEmailCommand request)
        {
            var deleteMail = await _mediator.Send(request);
           
            return new JsonResult(deleteMail);
        }

    }
}
