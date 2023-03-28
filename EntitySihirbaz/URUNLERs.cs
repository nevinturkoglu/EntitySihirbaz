namespace EntitySihirbaz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUNLERs
    {
        [Key]
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public string UrunMarkasi { get; set; }

        public string UrunKategorisi { get; set; }

        public string UrunStok { get; set; }

        public string Aciklama { get; set; }

        public int? Kategori_KategoriID { get; set; }

        public virtual Kategoris Kategoris { get; set; }
    }
}
