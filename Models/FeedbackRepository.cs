using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private AppDbContext _context;
        public FeedbackRepository(AppDbContext context)
        {
            _context = context;   
        }
        public void AddFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }
    }
}
