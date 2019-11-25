using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace launchPad.Models {

    public class LinkManager : DbContext {
        
        public LinkManager() {
        }

        public DbSet<Link> links {get; set;}
        public DbSet<Category> categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }

        public Link[] sortedLinks() {
            var query = links.OrderBy(c => c.categoryId).ThenByDescending(c => c.pinned).ThenBy(c => c.label);
            return query.ToArray();
            /*foreach(var line in query) {
                Console.WriteLine("cid: " + line.categoryId + " p: " + line.pinned + " l:" + line.label);
            } */
        }
    }
}
