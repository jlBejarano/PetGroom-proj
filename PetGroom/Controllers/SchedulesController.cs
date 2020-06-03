using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DHTMLX.Common;
using DHTMLX.Scheduler;
using DHTMLX.Scheduler.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetGroom.Data;
using PetGroom.Models;

namespace PetGroom.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public ActionResult Index()
        {
            var sched = new DHXScheduler();
            sched.Skin = DHXScheduler.Skins.Terrace;
            sched.LoadData = true;
            sched.EnableDataprocessor = true;
            sched.InitialDate = new DateTime(2020, 5, 5);
            return View(sched);
        }

        public ContentResult Data()
        {
            return new SchedulerAjaxData(
                new ApplicationDbContext().Schedules
                .Select(s => new { s.Id, s.Text, s.start_date, s.end_date })
                )
                ;
        }

        public ContentResult Save(int? id, ActionValue actionValues)
        {
            var Schedule = new DataAction(actionValues);
            var changedSchedule = DHXEventsHelper.Bind<Schedule>(actionValues);
            var entities = new ApplicationDbContext();
            try
            {
                switch (Schedule.Type)
                {
                    case DataActionTypes.Insert:
                        entities.Schedules.Add(changedSchedule);
                        break;
                    case DataActionTypes.Delete:
                        changedSchedule = entities.Schedules.FirstOrDefault(s => s.Id == Schedule.SourceId);
                        entities.Schedules.Remove(changedSchedule);
                        break;
                    default:
                        var target = entities.Schedules.Single(s => s.Id == changedSchedule.Id);
                        DHXEventsHelper.Update(target, changedSchedule, new List<string> { "id" });
                        break;
                }
                entities.SaveChanges();
                Schedule.TargetId = changedSchedule.Id;
                
            }
            catch (Exception a)
            {
                Schedule.Type = DataActionTypes.Error;
            }
            return new ApplicationDbContext(Schedule);
            
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Text,start_date,end_date")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text,start_date,end_date")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedules.Any(e => e.Id == id);
        }
    }
}
