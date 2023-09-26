namespace ChatConsoleTg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryMsg")]
    public partial class HistoryMsg
    {
        [Key]
        public int id_msg { get; set; }

        public string username { get; set; }

        public string msg { get; set; }

        public TimeSpan? time_msg { get; set; }
    }
}
