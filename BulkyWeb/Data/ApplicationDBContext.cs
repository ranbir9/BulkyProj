using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Action", displayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", displayOrder = 2 },
                new Category { Id = 3, Name = "History", displayOrder = 3 },
				new Category { Id = 4, Name = "Mystery", displayOrder = 4}
				); 
		}
	}
}

