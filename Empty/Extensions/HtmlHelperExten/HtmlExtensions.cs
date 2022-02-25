using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Empty.Extensions.HtmlHelperExten
{
    public static class HtmlExtensions
    {

        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value)
          =>// tek scope kod olduğu için return yerine kullandık.
            htmlHelper.TextBox(name, value, new
            {

                style = "background-color:green;color:white;font-size:14px;",
                //html etiketi içersindeki class nitleiğini direk kullanamıyoruz  çünkü  c# içinde anlamı lduğundan bunu ezmek için @ kullancazs
                @class = "form-input",// buraya bootstrapte kullanabiliriz
                a = "a"// buraya örnek olarak sallanmıştır örnek olsun diye a etiketine href gibi düşünebiliriz
                       // burdaki nitelik tamemen bizim kullanımııza kalmıstır
            });


    }
}
