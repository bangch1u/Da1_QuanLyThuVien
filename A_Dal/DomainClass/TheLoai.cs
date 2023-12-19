using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_Dal.DomainClass
{
    [Table("TheLoai")]
    public partial class TheLoai
    {
        public TheLoai()
        {
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
        }

        [Key]
        [Column("idTheLoai")]
        [StringLength(13)]
        [Unicode(false)]
        public string IdTheLoai { get; set; } = null!;
        [Column("tenTheLoai")]
        [StringLength(50)]
        public string? TenTheLoai { get; set; }
        [Column("viTriKeSach")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ViTriKeSach { get; set; }

        [InverseProperty("IdTheLoaiNavigation")]
        public virtual ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
    }
}
