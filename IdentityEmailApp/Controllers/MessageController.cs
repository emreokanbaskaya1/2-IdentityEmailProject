using IdentityEmailApp.Context;
using IdentityEmailApp.Entities;
using IdentityEmailApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityEmailApp.Controllers
{
    public class MessageController(AppDbContext _context, UserManager<AppUser> _userManager) : Controller
    {
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userName = User?.Identity?.Name;
            if (string.IsNullOrEmpty(userName))
            {
                return RedirectToAction("Index", "Login");
            }

            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return View(new List<Message>());
            }

            var messages = await _context.Messages
                .AsNoTracking()
                .Include(x => x.Sender)
                .Where(x => x.ReceiverId == user.Id)
                .OrderByDescending(x => x.SendDate)
                .ToListAsync();

            return View(messages);
        }

        public IActionResult MessageDetail(int id)
        {
            var message = _context.Messages.Include(x => x.Sender).FirstOrDefault(x=>x.MessageId == id);
            return View(message);
        }

        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageViewModel model)
        {
            var sender = await _userManager.FindByNameAsync(User.Identity?.Name);
            var receiver = await _userManager.FindByEmailAsync(model.ReceiverEmail);

            var message = new Message
            {
                Body = model.Body,
                Subject = model.Subject,
                ReceiverId = receiver.Id,
                SenderId = sender.Id,
                SendDate = DateTime.Now,
            };
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
