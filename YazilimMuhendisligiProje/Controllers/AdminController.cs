using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YazilimMuhendisligiProje.Dal;
using YazilimMuhendisligiProje.Models;

namespace YazilimMuhendisligiProje.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Test
        public async Task<ActionResult> Index()
        {
            return View(await db.TestItem.ToListAsync());
        }

        // GET: Test/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestItemModels testItemModels = await db.TestItem.FindAsync(id);
            if (testItemModels == null)
            {
                return HttpNotFound();
            }
            return View(testItemModels);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Question,OptionA,OptionB,OptionC,OptionD")] TestItemModels testItemModels)
        {
            if (ModelState.IsValid)
            {
                db.TestItem.Add(testItemModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(testItemModels);
        }

        // GET: Test/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestItemModels testItemModels = await db.TestItem.FindAsync(id);
            if (testItemModels == null)
            {
                return HttpNotFound();
            }
            return View(testItemModels);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Question,OptionA,OptionB,OptionC,OptionD")] TestItemModels testItemModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testItemModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(testItemModels);
        }

        // GET: Test/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestItemModels testItemModels = await db.TestItem.FindAsync(id);
            if (testItemModels == null)
            {
                return HttpNotFound();
            }
            return View(testItemModels);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TestItemModels testItemModels = await db.TestItem.FindAsync(id);
            db.TestItem.Remove(testItemModels);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
