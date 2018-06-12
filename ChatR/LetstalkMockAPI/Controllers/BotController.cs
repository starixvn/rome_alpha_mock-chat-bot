using System.Collections.Generic;
using System.Web.Http;
using LetstalkMockAPI.Models;
using LetstalkMockAPI.ViewModels;
using LetstalkMockAPI.Web;

namespace LetstalkMockAPI.Controllers
{
    public class BotController : ApiController
    {
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
                    status = 1,
                    message = "success",
                    tags = new string[] { "tag1", "tag2" }
                },
                Request);

        [HttpGet]
        [Route("api/bot/get_contacts/{user_name}")]
        public IHttpActionResult GetContacts(string user_name, string tag)
            => new JsonResult(
                new GetContactsResult
                {
                    status = 1,
                    message = "success",
                    tag = tag,
                    Contacts = new List<Contact>
                    {
                        new Contact {user_id="1",avatar_url="avatar_url", display_name="display_name" },
                        new Contact {user_id="2",avatar_url="avatar_url", display_name="display_name" }
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
            => new JsonResult(new PublicKeyResult { status = 1, message = "success", public_key = "public_key" }, Request);

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
                   status = 1,
                   message = "success",
                   avatar_url = "avatar_url",
                   display_name = "display_name"
               },
               Request);

        private JsonResult SuccessJsonResult()
            => new JsonResult(new SuccessResult(), Request);

        private JsonResult FailureJsonResult()
            => new JsonResult(new FailureResult(), Request);
    }
}
