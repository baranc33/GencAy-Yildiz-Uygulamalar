using ViewModelAndDto.Models.ViewModel;

namespace ViewModelAndDto.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool MedeniHAl { get; set; }


        public static implicit operator PersonelCreateViewModel(Personel p)
        {

            return new  PersonelCreateViewModel
            {
               Adi = p.Adi,
               SoyAdi=p.SoyAdi
            };
        }


        public static implicit operator Personel(PersonelCreateViewModel p)
        {

            return new Personel
            {
                Adi = p.Adi,
                SoyAdi = p.SoyAdi
            };
        }
    }

}
