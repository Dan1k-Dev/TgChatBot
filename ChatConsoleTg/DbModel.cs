using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChatConsoleTg
{
    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=TgChatDbModel")
        {
        }

        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<HistoryMsg> HistoryMsgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
