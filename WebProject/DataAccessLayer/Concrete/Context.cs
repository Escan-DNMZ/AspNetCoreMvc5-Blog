using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilde)
        {
            optionsBuilde.UseSqlServer("server=LAPTOP-K9OQTN1D\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;"); 
        }
        /* One To Many Message tablosunu Writer a bağlayarak ordan Sender ve Receiver Id sini aldık
        ardından Message2 de ise bu Message da bulunan Sender ve Receiver Id sini Message2 ye aktardık */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // message - writer - message
            modelBuilder.Entity<Message2>()
                .HasOne(message => message.SenderUser) // escan
                .WithMany(writer => writer.WriterSender) // birden fazla mesaj gonderdı
                .HasForeignKey(message => message.SenderId) // escana ulaştım
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);


        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLatter> NewsLatters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Messages2 { get; set; }
    }
}
