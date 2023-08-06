using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }
        public double TotalCalories { get; set; }
        public double Scale { get; set; }

        public Recipe(String name)
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
            this.Name = name;
        }

        public void AddIngredient(string name, double quantity, string unit) { 
            Ingredient ingredient= new Ingredient();
            ingredient.Name = name;
            ingredient.Quantity = quantity;
            ingredient.UnitOfMeasurement = unit;

            this.Ingredients.Add(ingredient);
        
        }

        public void RemoveIngredient(Ingredient selectedIngredient) { 
            this.Ingredients.Remove(selectedIngredient);
        }

        public void AddStep(string description)
        {
            Step step = new Step(description);
            this.Steps.Add(step);
        }

        public void RemoveStep(Step selectedStep) { 
        
            this.Steps.Remove(selectedStep);

        }

    }
}





