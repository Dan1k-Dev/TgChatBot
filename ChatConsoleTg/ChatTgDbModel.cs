using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChatConsoleTg
{
    public partial class ChatTgDbModel : DbContext
    {
        public ChatTgDbModel()
            : base("name=ChatTgDbModel")
        {
        }

        public virtual DbSet<HistoryMessage> HistoryMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
