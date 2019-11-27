using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace launchPad.Models {

    public class LinkManager : DbContext {

        private Link[] query;
        
        public LinkManager() {
        }

        public DbSet<Link> links {get; set;}
        public DbSet<Category> categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }

        public Link[] sortedLinks() {
            query = links.OrderBy(c => c.categoryId).ThenByDescending(c => c.pinned).ThenBy(c => c.label).ToArray();
            return query;
        }

        public Category getCategory(int catId) {
            Category cat = categories.FirstOrDefault(c => c.Id == catId);
            Console.WriteLine("\n\n*****category in Model: " + cat.category);
            return cat;
        }

        public Category populateEditCategory(int Id) {
            return categories.FirstOrDefault(c => c.Id == Id);
        }
    }
}
