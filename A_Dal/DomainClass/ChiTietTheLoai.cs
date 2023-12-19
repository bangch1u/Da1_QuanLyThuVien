using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_Dal.DomainClass
{
    [Table("ChiTietTheLoai")]
    public partial class ChiTietTheLoai
    {
        [Key]
        [Column("idTheLoai")]
        [StringLength(13)]
        [Unicode(false)]
        public string IdTheLoai { get; set; } = null!;
        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!;
        [Column("moTa")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MoTa { get; set; }

        [ForeignKey("BarCodeSach")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual Sach BarCodeSachNavigation { get; set; } = null!;
        [ForeignKey("IdTheLoai")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual TheLoai IdTheLoaiNavigation { get; set; } = null!;
    }
}
