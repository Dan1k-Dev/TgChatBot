namespace ChatConsoleTg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HistoryMessage
    {
        [Key]
        public int idMsg { get; set; }

        public string username { get; set; }

        public string message { get; set; }

        public string recipient { get; set; }
    }
}
