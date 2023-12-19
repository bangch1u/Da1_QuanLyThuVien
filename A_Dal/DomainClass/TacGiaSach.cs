using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_Dal.DomainClass
{
    [Table("TacGiaSach")]
    public partial class TacGiaSach
    {
        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!;
        [Key]
        [Column("idTacGia")]
        [StringLength(13)]
        [Unicode(false)]
        public string IdTacGia { get; set; } = null!;
        [Column("moTa")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MoTa { get; set; }

        [ForeignKey("BarCodeSach")]
        [InverseProperty("TacGiaSaches")]
        public virtual Sach BarCodeSachNavigation { get; set; } = null!;
        [ForeignKey("IdTacGia")]
        [InverseProperty("TacGiaSaches")]
        public virtual TacGium IdTacGiaNavigation { get; set; } = null!;
    }
}
