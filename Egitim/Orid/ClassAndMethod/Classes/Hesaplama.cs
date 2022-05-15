
//Namespace => Classın Bulundu Konum
namespace ClassAndMethod.Classes
{// name SpaceBaşlama Scope

    public class Hesaplama // class tanımlama
    {
        // verilerimizi ve Metotlarımızı Buraya Yazarız



        // Metot Oluşturma 
        // Er =Erişim Belirteci  
        // Gr =   Geriye Dönüş Türü
        // Er + Gr + Metodun ismi + (Gönderilen Değerler)
        // {
        //      kodlarımız
        // }

        public int ToplamaMetodu(string sayi1 ,string sayi2)
        {
            int sayi3 = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);

            return sayi3;
        }


    }


}// name Space Bitiş Scope

