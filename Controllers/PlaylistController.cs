using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Eargasm.Models;
using Eargasm.Data;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Web;

namespace Eargasm.Controllers
{
    [Authorize]
    public class PlaylistController : Controller

    {
        private readonly EargasmContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public PlaylistController(EargasmContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Playlist
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Playlist == null)
            {
                return Problem("Entity set 'EargasmContext.Playlist'  is null.");
            }

            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var playlists = from m in _context.Playlist
                            select m;

            playlists = playlists.Where(x => x.UserId.Equals(user.Id));

            if (!String.IsNullOrEmpty(searchString))
            {
                playlists = playlists.Where(s => s.Title!.Contains(searchString));
            }
            return View(await playlists.ToListAsync());
        }

        // GET: Playlist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Playlist == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

        // GET: Playlist/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Url")] Playlist playlist)
        {
            //Testing
            //Console.Write("Work yye cunt");
            string path = new Uri(playlist.Url).AbsolutePath;
            //Testing
            //Console.Write(path.ToString()); 
            var processStartInfo = new ProcessStartInfo
            {
                Arguments = string.Format("{0} {1}", "Controllers/getcsv.py", path),
                FileName = "python.exe",
                //FileName = Environment.GetEnvironmentVariable("WINDIR") + (@"\explorer.exe", "C:/Python310"),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            Process.Start(processStartInfo);

            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            // go ahead and save it into the database
            // redirectToAction()
            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            playlist.UserId = user.Id;
            playlist.Created = DateTime.Now;
            _context.Playlist.Add(playlist);
            _context.SaveChanges();
            return RedirectToAction("Index");

            return View(playlist);
            // Console.WriteLine(post.Text + " " + post.Title);
            // return RedirectToAction("Test");
        }

        // GET: Playlist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Playlist == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist.FindAsync(id);
            if (playlist == null)
            {
                return NotFound();
            }
            return View(playlist);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Url")] Playlist playlist)
        {
            if (id != playlist.Id)
            {
                return NotFound();
            }
            try
            {
                _context.Update(playlist);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaylistExists(playlist.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
            return View(playlist);
        }

        // GET: Playlist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Playlist == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Playlist == null)
            {
                return Problem("Entity set 'EargasmContext.Playlist'  is null.");
            }
            var playlist = await _context.Playlist.FindAsync(id);
            if (playlist != null)
            {
                _context.Playlist.Remove(playlist);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaylistExists(int id)
        {
            return (_context.Playlist?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
