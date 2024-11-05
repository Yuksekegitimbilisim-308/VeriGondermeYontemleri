using VeriGondermeYontemleri.Entities;

namespace VeriGondermeYontemleri.Models
{

    //ViewModel
    //DTO(Data Transfer Object)
    public class HomeIndexVM
    {
        public Personel Personel{ get; set; }
        public Deparment Department { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
