using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketWeb.Models
{
    public class LoaiVe
    {
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "ID ")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "ID-Chuyến bay")]
        public int ChuyenBay_ID { get; set; }
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "Code")]
        public string Code{ get; set; }
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "Tên vé")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "Giá vé")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Bạn cần điền thông tin vào đây")]
        [Display(Name = "Giá vé USD")]
        public int Price_USD { get; set; }
    }
}
