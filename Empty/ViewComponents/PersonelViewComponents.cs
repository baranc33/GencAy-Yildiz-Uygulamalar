using Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empty.ViewComponents
{
    public class PersonelViewComponent : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            List<Personel> datas = new List<Personel>()
            {
                new Personel{Adi="Hakan Baran",SoyAdi="Çakır"},
                new Personel{Adi="Müjdat",SoyAdi="Özkan"},
                new Personel{Adi="Melih Ömer",SoyAdi="Kamar"},
                new Personel{Adi="Ayhan",SoyAdi="Buğdaycı"},
            };

            return View(datas);
        }
    }
}
