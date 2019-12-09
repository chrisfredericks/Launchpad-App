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

        // set up entities
        public DbSet<Link> links {get; set;}
        public DbSet<Category> categories {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Connection.CONNECTION_STRING);
        }


        public Link[] sortedLinks() {
            // order the links to be able to display them correctly
            query = links.OrderBy(c => c.categoryId).ThenByDescending(c => c.pinned).ThenBy(c => c.label).ToArray();
            return query;
        }

        public List<Category> getList() {
            // create list for dropdown
            return categories.OrderBy(c => c.category).ToList();
        }

        public Category getCategory(int catId) {
            // get the category for display
            Category cat = categories.FirstOrDefault(c => c.Id == catId);
            return cat;
        }

        public Link populateDeleteLink(int Id) {
            // populate the delete view with selected link
            return links.FirstOrDefault(c => c.Id == Id);
        }

        public Category populateEditCategory(int Id) {
            // populate the edit category view with selected category
            return categories.FirstOrDefault(c => c.Id == Id);
        }

        public Link populateEditLink(int Id) {
            // populate the edit link view with selected link
            return links.FirstOrDefault(c => c.Id == Id);
        }
    }
}
