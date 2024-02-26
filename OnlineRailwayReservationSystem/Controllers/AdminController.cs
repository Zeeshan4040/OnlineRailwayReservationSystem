using Microsoft.AspNetCore.Mvc;

namespace OnlineRailwayReservationSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult StationMaster()
        {
            return View();
        }
        public IActionResult StationMasterEdit()
        {
            return View();
        }
        public IActionResult TrainMaster()
        {
            return View();
        }
        public IActionResult TrainMasterEdit()
        {
            return View();
        }
        public IActionResult TrainScheduleMaster()
        {
            return View();
        }
        public IActionResult TrainScheduleMasterEdit()
        {
            return View();
        }
        public IActionResult FareRule()
        {
            return View();
        }
        public IActionResult CancellationFees()
        {
            return View();
        }
        public IActionResult ReservationFees()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult ReservationBooking()
        {
            return View();
        }
        public IActionResult ReservationBookingConfirmation()
        {
            return View();
        }
        public IActionResult Cancellation()
        {
            return View();
        }
        public IActionResult Transaction()
        {
            return View();
        }
        public IActionResult PNRInquiry()
        {
            return View();
        }
    }
}
