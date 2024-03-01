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
            var TrainData = _context.tbl_TrainMaster.ToList();
            return View(TrainData);
        }
        public IActionResult TrainMasterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TrainMasterAdd(TrainMaster trainMaster)
        {
            _context.tbl_TrainMaster.Add(trainMaster);
            _context.SaveChanges();
            return RedirectToAction("TrainMaster");
        }
        public IActionResult TrainMasterEdit(int id)
        {
            var updateData = _context.tbl_TrainMaster.Find(id);
            return View(updateData);
        }
        [HttpPost]
        public IActionResult TrainMasterEdit(TrainMaster trainMaster)
        {
            _context.tbl_TrainMaster.Update(trainMaster);
            _context.SaveChanges();
            return RedirectToAction("TrainMaster");
        }
        public IActionResult TrainScheduleMaster(TrainScheduleMaster trainScheduleMaster)
        {
            var ScheduleData = _context.tbl_TrainScheduleMaster.ToList();
            return View(ScheduleData);
        }
        public IActionResult TrainScheduleMasterAdd()
        {
            var TrainData = _context.tbl_TrainMaster.ToList();
            var StationData = _context.tbl_StationMaster.ToList();

            ViewData["TrainData"] = TrainData;
            ViewData["StationData"] = StationData;

            return View();
        }
        [HttpPost]
        public IActionResult TrainScheduleMasterAdd(TrainScheduleMaster trainScheduleMaster)
        {
            _context.tbl_TrainScheduleMaster.Add(trainScheduleMaster);
            _context.SaveChanges();
            return RedirectToAction("TrainScheduleMaster");
        }
        public IActionResult TrainScheduleMasterEdit(int id)
        {
            var TrainData = _context.tbl_TrainMaster.ToList();
            var StationData = _context.tbl_StationMaster.ToList();

            ViewData["TrainData"] = TrainData;
            ViewData["StationData"] = StationData;

            var updateData = _context.tbl_TrainScheduleMaster.Find(id);
            return View(updateData);
        }
        [HttpPost]
        public IActionResult TrainScheduleMasterEdit(TrainScheduleMaster trainScheduleMaster)
        {
            _context.tbl_TrainScheduleMaster.Update(trainScheduleMaster);
            _context.SaveChanges();
            return RedirectToAction("TrainScheduleMaster");
        }
        public IActionResult FareRule()
        {
            var FareRule = _context.tbl_FareRule.ToList();
            return View(FareRule);
        }
        public IActionResult FareRuleAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FareRuleAdd(FareRule fareRule)
        {
            _context.tbl_FareRule.Add(fareRule);
            _context.SaveChanges();
            return RedirectToAction("FareRule");
        }
        public IActionResult FareRuleEdit(int id)
        {
            var UpdateData = _context.tbl_FareRule.Find(id);
            return View(UpdateData);
        }
        [HttpPost]
        public IActionResult FareRuleEdit(FareRule fareRule)
        {
            _context.tbl_FareRule.Update(fareRule);
            _context.SaveChanges();
            return RedirectToAction("FareRule");
        }
        public IActionResult CancellationFees()
        {
            var cancellationFees = _context.tbl_CancellationFees.ToList();
            return View(cancellationFees);
        }
        public IActionResult CancellationFeesAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CancellationFeesAdd(CancellationFees cancellationFees)
        {
            _context.tbl_CancellationFees.Add(cancellationFees);
            _context.SaveChanges();
            return RedirectToAction("CancellationFees");
        }
        public IActionResult CancellationFeesEdit(int id) 
        {
            var UpdateData = _context.tbl_CancellationFees.Find(id);
            return View(UpdateData);
        }
        [HttpPost]
        public IActionResult CancellationFeesEdit(CancellationFees cancellationFees) 
        {
            _context.tbl_CancellationFees.Update(cancellationFees);
            _context.SaveChanges();
            return RedirectToAction("cancellationFees");
        }
        public IActionResult ReservationFees()
        {
            var ReservationFees = _context.tbl_ReservationFees.ToList();
            return View(ReservationFees);
        }
        public IActionResult ReservationFeesAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReservationFeesAdd(ReservationFees reservationFees)
        {
            _context.tbl_ReservationFees.Add(reservationFees);
            _context.SaveChanges();
            return RedirectToAction("ReservationFees");
        }
        public IActionResult ReservationFeesEdit(int id)
        {
            var UpdateData = _context.tbl_ReservationFees.Find(id);
            return View(UpdateData);
        }
        [HttpPost]
        public IActionResult ReservationFeesEdit(ReservationFees reservationFees)
        {
            _context.tbl_ReservationFees.Update(reservationFees);
            _context.SaveChanges();
            return RedirectToAction("ReservationFees");
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
