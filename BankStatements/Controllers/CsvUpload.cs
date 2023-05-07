using BankStatements.Data;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using System.IO;
using CsvHelper.Configuration;
using BankStatements.Models;
using BankStatements.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankStatements.Controllers
{
    public class CsvUpload : Controller
    {
        private readonly ApplicationDbContext _context;
        public CsvUpload(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.Statements != null ?
                          View(await _context.Statements.ToListAsync()) :
                          Problem("Entity set 'Statements'  is null.");
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormCollection form)
        {
            var data = form["csvFile"];
            if (Request.Form.Files.Count > 0)
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    Comment = '#',
                    HasHeaderRecord = false
                };

                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    dataStream.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(dataStream))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Context.RegisterClassMap<StatementMap>();
                        var statements = csv.GetRecords<Statement>();

                        if (statements != null)
                        {
                            foreach (Statement statement in statements)
                            {
                                _context.Add(statement);
                            }

                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }

    }
}
