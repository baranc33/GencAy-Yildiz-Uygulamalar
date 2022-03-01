using Microsoft.AspNetCore.Mvc;

namespace Empty.ViewComponents
{
    public class PersonelViewComponent : ViewComponent
    {
       public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
