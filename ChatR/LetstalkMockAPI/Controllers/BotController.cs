using System.Collections.Generic;
using System.Web.Http;
using LetstalkMockAPI.Models;
using LetstalkMockAPI.ViewModels;
using LetstalkMockAPI.Web;

namespace LetstalkMockAPI.Controllers
{
    public class BotController : ApiController
    {
        [HttpPut]
        [Route("api/bot/change_display_name/{user_name}")]
        public IHttpActionResult ChangeDisplayName(string user_name, [FromBody]ChangeDisplayNameViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/upload_avatar_image/{user_name}")]
        public IHttpActionResult UploadAvatarImage(string user_name, [FromBody]UploadAvatarImageViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/set_welcome_msg/{user_name}")]
        public IHttpActionResult SetWelcomeMsg(string user_name, [FromBody]SetWelcomeMsgViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/set_auto_reply/{user_name}")]
        public IHttpActionResult SetAutoReply(string user_name, [FromBody]SetAutoReplyViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        public IHttpActionResult Push(string user_name, [FromBody]PushMessageViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/push_to_tag/{user_name}")]
        public IHttpActionResult PushToTag(string user_name, [FromBody]PushToTagViewModel body)
            => SuccessJsonResult();

        [HttpPost, HttpDelete]
        [Route("api/bot/modify_tag/{user_name}")]
        public IHttpActionResult ModifyTag(string user_name, [FromBody]ModifyTagViewModel body)
            => SuccessJsonResult();

        [HttpGet]
        [Route("api/bot/list_tag/{user_name}")]
        public IHttpActionResult ListTag(string user_name)
            => new JsonResult(
                new ListTagResult
                {
                    Status = 1,
                    Message = "success",
                    Tags = new string[] { "tag1", "tag2" }
                },
                Request);

        [HttpGet]
        [Route("api/bot/get_contacts/{user_name}")]
        public IHttpActionResult GetContacts(string user_name, string tag)
            => new JsonResult(
                new GetContactsResult
                {
                    Status = 1,
                    Message = "success",
                    Tag = tag,
                    Contacts = new List<Contact>
                    {
                        new Contact {UserId="1",AvatarUrl="avatar_url", DisplayName="display_name" },
                        new Contact {UserId="2",AvatarUrl="avatar_url", DisplayName="display_name" }
                    }
                },
                Request);

        [HttpPost, HttpDelete]
        [Route("api/bot/modify_contact_tag/{user_name}")]
        public IHttpActionResult ModifyContactTag(string user_name, [FromBody]ModifyContactTagViewModel body)
            => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/set_hash_key/{user_name}")]
        public IHttpActionResult SetHashKey(string user_name, [FromBody]SetHashKeyViewModel body)
            => SuccessJsonResult();

        [HttpGet]
        [Route("api/bot/get_contact_public_key/{user_name}")]
        public IHttpActionResult GetContactPublicKey(string user_name, string contact)
            => new JsonResult(new PublicKeyResult { Status = 1, Message = "success", PublicKey = "public_key" }, Request);

        [HttpPost]
        [Route("api/bot/set_key_to_contact/{user_name}")]
        public IHttpActionResult SetKeyToContact(string user_name, [FromBody]SetKeyToContactViewModel body)
           => SuccessJsonResult();

        [HttpPost]
        [Route("api/bot/set_webhook/{user_name}")]
        public IHttpActionResult SetWebhook(string user_name, [FromBody]SetWebhookViewModel body)
           => SuccessJsonResult();

        [HttpGet]
        [Route("api/bot/get_profile/{user_name}")]
        public IHttpActionResult GetProfile(string user_name, [FromBody]GetProfileViewModel body)
           => new JsonResult(
               new GetProfileResult
               {
                   Status = 1,
                   Message = "success",
                   AvartaUrl = "avatar_url",
                   DisplayName = "display_name"
               },
               Request);

        private JsonResult SuccessJsonResult()
            => new JsonResult(new SuccessResult(), Request);

        private JsonResult FailureJsonResult()
            => new JsonResult(new FailureResult(), Request);
    }
}
