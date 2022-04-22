using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Empty.Extensions.TagHelpers
{
    //[HtmlTargetElement("YeniIsim")]
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; }
        public string Display{ get; set; }

        //ilgili taghelpere verdiğimiz biütün değerleri verir 
        //output ise yapacağı işlemleri sunar.
        // biz taghelperımıza çıktı vermek için output kullancaz
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName= "a";// buraı oluşturacağı etiketi temsil eder a link yada p paragraf h1 başlık gibi
            output.Attributes.Add("href", $"mailto:{Mail}");// a tagına eklenecek nitelik kendi href özelliği
            // burdaki mailto htmlde maile yönlendirme özelliği c# laa alakalı değildir.
            // 2. paramterede ise  verilen mail değeri hrefe gelecek değer ddynamic olarak almıs olduk
            output.Content.Append(Display);// buda <a>Display</a>
        }
    }

}
