using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
    public class Daily
    {
        [Key]
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? DienThoai { get; set; }
        public string? MaHTPP { get; set; } // liên kết với HeThongPhanPhoi
    }
}