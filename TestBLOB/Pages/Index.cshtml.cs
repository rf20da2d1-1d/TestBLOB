using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Drawing;
using System.Linq;
using TestBLOB.model;

namespace TestBLOB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Foto _foto;
        private List<Foto> _fotos;

        public Foto Foto
        {
            get => _foto;
            set => _foto = value;
        }

        public List<Foto> Fotos
        {
            get => _fotos;
            set => _fotos = value;
        }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FotodbContext db = new FotodbContext();
            _fotos = db.Fotos.ToList();
            _foto = _fotos[0];
        }
    }
}
