namespace ChatConsoleTg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Archive")]
    public partial class Archive
    {
        public int id { get; set; }

        public string msg_content { get; set; }
    }
}
