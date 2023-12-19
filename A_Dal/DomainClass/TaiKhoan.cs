using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_Dal.DomainClass
{
    [Table("TaiKhoan")]
    [Index("IdNhanVien", Name = "UQ__TaiKhoan__214E8259293F86C6", IsUnique = true)]
    public partial class TaiKhoan
    {
        [Key]
        [Column("idTaiKhoan")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdTaiKhoan { get; set; } = null!;
        [Column("userName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [Column("passWord")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PassWord { get; set; }
        [Column("idNhanVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdNhanVien { get; set; }
        [Column("role")]
        public int? Role { get; set; }

        [ForeignKey("IdNhanVien")]
        [InverseProperty("TaiKhoan")]
        public virtual NhanVien? IdNhanVienNavigation { get; set; }
    }
}
