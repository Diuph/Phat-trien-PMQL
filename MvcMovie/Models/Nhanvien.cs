using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("NhanViens")] // tên bảng trong cơ sở dữ liệu (nếu cần)
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Address { get; set; }
    }
}