using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_Dal.DomainClass
{
    public partial class TacGium
    {
        public TacGium()
        {
            TacGiaSaches = new HashSet<TacGiaSach>();
        }

        [Key]
        [Column("idTacGia")]
        [StringLength(13)]
        [Unicode(false)]
        public string IdTacGia { get; set; } = null!;
        [Column("hoTen")]
        [StringLength(100)]
        public string? HoTen { get; set; }
        [Column("ngaySinh", TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [InverseProperty("IdTacGiaNavigation")]
        public virtual ICollection<TacGiaSach> TacGiaSaches { get; set; }
    }
}
