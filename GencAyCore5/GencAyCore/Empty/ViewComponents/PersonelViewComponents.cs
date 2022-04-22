using Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empty.ViewComponents
{
    //[NonViewComponent] Bu şekilde render edilmesini engelleyebiliriz
    public class PersonelViewComponent : ViewComponent
    {
        // aldığı parametre açğrıldı yerde geçilir parametre almak zorunda değil
        public IViewComponentResult Invoke(int id)
        {
            // bu verilerin veri tabanından geldiğini farz ediyorum
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
