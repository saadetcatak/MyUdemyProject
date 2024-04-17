using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(50, ErrorMessage = "Hizmet başlığı en fazla 50 karakter olmalıdır")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet başlığı en fazla 500 karakter olmalıdır")]
        public string Description { get; set; }
    }
}
