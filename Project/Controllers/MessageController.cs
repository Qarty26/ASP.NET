using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
using Roads.Models.DTOs;

namespace Roads.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] MessageRequestDTO request)
        {
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = request.Title,
                    Body = request.Body
                },
                Token = request.DeviceToken
            };

            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);

            if (!string.IsNullOrEmpty(result))
            {
                return Ok("Message sent successfully!");
            }
            else
            {
                throw new Exception("Error sending the message.");
            }
        }
    }
}
