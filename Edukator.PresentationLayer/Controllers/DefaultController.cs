using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMailSubscribeService _mailSubscribeService;

        public DefaultController(IMailSubscribeService mailSubscribeService)
        {
            _mailSubscribeService = mailSubscribeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddMailSubscribe()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddMailSubscribe(MailSubscribe mailSubscribe)
        {
            _mailSubscribeService.TInsert(mailSubscribe);
            return RedirectToAction("Index");
        }
    }
}
