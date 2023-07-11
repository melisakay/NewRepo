using Microsoft.AspNetCore.Mvc;
using P016_IlkWebProjem.Models;

namespace P016_IlkWebProjem.Controllers
{
	public class PersonelController : Controller
	{
		public IActionResult Index()
		{
			Personel p1 = new Personel() { Ad="Selami", Soyad="Şahin", Departman="Müzik", Aktif=true };

			return View(p1);
		}
	}
}