using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class CakesInitiallizer : DropCreateDatabaseAlways<CakesContext>
    {
        protected override void Seed(CakesContext context)
        {
            SpeedKursyData(context);
            base.Seed(context);
        }

        private void SpeedKursyData(CakesContext context)
        {
            var categories = new List<Category>
            {
                new Category() {CategoryId = 1, CategoryName = "Birthday",
                    IconFileName = "icon.png", CategoryDescription = "Suprise your friends!"},
                new Category() {CategoryId = 2, CategoryName = "Nameday",
                    IconFileName = "icon2.png", CategoryDescription = "Fast to do!"}
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var cakes = new List<Cake>
            {
                new Cake() {CakeName = "Madagaskar", CategoryId = 1,
                    CakeDescription = "Super easy and tasty!", CakeMainIngredient = "Coconut"}
            };

            cakes.ForEach(c => context.Cakes.Add(c));
            context.SaveChanges();
        }
    }
}