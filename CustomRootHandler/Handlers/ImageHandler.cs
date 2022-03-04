using ImageMagick;

namespace CustomRootHandler.Handlers
{
    public class ImageHandler
    {

        public RequestDelegate Handler(string filePath)
        {
            // geriye task döneceği için async yazıyoruz
            return async x =>
            {
                // Resmi  bu şekilde buluyoruz.
                FileInfo fileInfo = new FileInfo($"{filePath}\\{x.Request.RouteValues["ImageName"].ToString()}");

                // aşşağıdaki kütüphane otomatik boyutlandırmamıza yardımcı oluyor.
                // using kelimesi sayesinde nesne işi bitince dispose edilmesini sağlıyor
                using MagickImage magick = new MagickImage(fileInfo);

                //resmin orjinal değerlerini alalım
                int width = magick.Width, height = magick.Height;

                // şimdi queryStringten kelen ayarlanacak a değerleri ayarliyalım
                // www.localhost:123/image/ImageName?w=100&h=200   gelen request bu şekilde
                if (!string.IsNullOrEmpty(x.Request.Query["w"].ToString()))// queryStringte w varmı diye bakıyoruz.
                {
                    width = int.Parse(x.Request.Query["w"].ToString());
                }

                if (!string.IsNullOrEmpty(x.Request.Query["h"].ToString()))
                {
                    height = int.Parse(x.Request.Query["h"].ToString());
                }

                // bu işlemleri gerçekleştir
                magick.Resize(width, height);
                // resmi byte formatına çevirelim
                var buffer = magick.ToByteArray();
                x.Response.Clear();// gelen isteği temizleylim
                // uzantısını alıp . sını silip geri gönderelim
                x.Response.ContentType = String.Concat("image/", fileInfo.Extension.Replace(".",""));

                // gidecek isteğe dosyanın bodysene yazalım
                await x.Response.Body.WriteAsync(buffer, 0, buffer.Length);

                await x.Response.WriteAsync(filePath);

            };


        }
    }
}
