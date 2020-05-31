using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanyShop.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository FeedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            FeedbackRepository = feedbackRepository;
        }
        [HttpGet]
        [Route("Feedback/New")]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Feedback feedback)
        {
            FeedbackRepository.AddFeedback(feedback);
            return RedirectToAction("FeedbackComplete");
        }
        [Route("Feedback/FeedbackComplete")]
        public IActionResult FeedbackComplete()
        {
            return View();

        }
    }
}