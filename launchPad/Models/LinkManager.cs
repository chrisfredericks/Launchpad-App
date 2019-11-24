using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace launchPad.Models {

    public class LinkManager : DbContext {

        private List<launchPad.Models.Link> _categories;
        
        public LinkManager() {
            _categories = new List<Link>();
        }

        public DbSet<Link> links {get; set;}

        public List<Link> categories {
            get {
                return _categories;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }

        public List<Link> getCategories() {
            _categories = links.GroupBy (c => c.category).Select (y => y.First ()).ToList();
            // var _categories = links.Select(c => c.category).Distinct().ToList();
            return _categories;
        }
    }
}
