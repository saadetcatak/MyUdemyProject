using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarası Yazınız")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }

        [StringLength(10, ErrorMessage ="Lütfen En Az 10 Karakter Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısı Giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
