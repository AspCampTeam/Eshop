using Application.Interface;
using Domain.IRepositories;
using Domain.ViewModels.Ticket;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Areas.Admin.Controllers
{
    
    public class HomeController : AdminBaseController
    {
        private IUserService _userService;
        private ITicketService _ticketService;
        private IOrderService _orderService;

        public HomeController(IUserService userService, ITicketService ticketService, IOrderService orderService)
        {
            _userService = userService;
            _ticketService = ticketService;
            _orderService = orderService;
        }


        [Route("")]
        public async Task<IActionResult> Index(UserTicketsListViewModel model)
        {
            var ticket = await _ticketService.GetNoReadTickets(model);
            ViewData["OrderPartialModel"] = await _orderService.GetFinalizedOrdersForAdmin();
               var res= await _orderService.GetSalesOrderChartForAdmin();
               ViewData["SalesPartialModel"] = res;
            return View(ticket);
            
        }

        [Route("Logs")]
        public async Task<IActionResult> Logs()
        {

            return View();
        }

    }
}
