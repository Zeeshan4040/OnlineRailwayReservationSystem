using Microsoft.AspNetCore.Mvc;
using OnlineRailwayReservationSystem.Models;

namespace OnlineRailwayReservationSystem.Controllers
{
    public class AdminController : Controller
    {
        private myContext _context;
        public AdminController(myContext context) {
            _context = context;
        }
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
            var StationData = _context.tbl_StationMaster.ToList();
            return View(StationData);
        }
        public IActionResult StationMasterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StationMasterAdd(StationMaster stationMaster)
        {
            _context.tbl_StationMaster.Add(stationMaster);
            _context.SaveChanges();
            return RedirectToAction("StationMaster");
        }
        public IActionResult StationMasterEdit(int id)
        {
            var updateData = _context.tbl_StationMaster.Find(id);
            return View(updateData);
        }
        [HttpPost]
        public IActionResult StationMasterEdit(StationMaster stationMaster)
        {
            _context.tbl_StationMaster.Update(stationMaster);
            _context.SaveChanges();
            return RedirectToAction("StationMaster");
        }
        public IActionResult TrainMaster()
        {
            return View();
        }
        public IActionResult TrainMasterAdd()
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
        public IActionResult TrainScheduleMasterAdd()
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
