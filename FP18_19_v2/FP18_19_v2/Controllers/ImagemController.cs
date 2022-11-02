using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FP18_19_v2.Data;
using FP18_19_v2.Models;

namespace FP18_19_v2.Controllers
{
    public class ImagemController : Controller
    {
        private readonly FP18_19_v2Context _context;

        public ImagemController(FP18_19_v2Context context)
        {
            _context = context;
        }

        // GET: Imagem
        public async Task<IActionResult> Index()
        {
            return View(await _context.Imagem.OrderBy(x => x.DataRegisto).ToListAsync());
        }

        // GET: Courses/Create
        public IActionResult Upload()
        {
            return View();
        }

        public async Task<IActionResult> Gosto(int? id)
        {
            if(id==null || _context.Imagem == null)
            { return NotFound(); }

            var imagem = await _context.Imagem.FirstOrDefaultAsync(m => m.Id == id);
            
            if(imagem==null)
            { return NotFound(); }

            imagem.Gostos++;

            _context.Update(imagem);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Upload(IFormFile CaminhoFicheiro, Imagem img)
        {
            try
            {
                string disc = img.Descricao;
                string fileName = Path.GetFileName(CaminhoFicheiro.FileName);
                string upPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Image", fileName);

                var stream = new FileStream(upPath, FileMode.Create);
                CaminhoFicheiro.CopyToAsync(stream);
                Imagem imagem = new Imagem
                {
                    CaminhoFicheiro = CaminhoFicheiro.FileName,
                    DataRegisto = DateTime.Now,
                    Descricao=disc,
                    Gostos = 0
                };
                _context.Add(imagem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}