using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using RecipeApp;



namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        private Recipe selectedRecipe;
        private List<Recipe> recipes;

        public MainWindow()
        {
            InitializeComponent();


            recipes = new List<Recipe>
            {
                new Recipe("Recipe 1"),
                new Recipe("Recipe 2"),
                new Recipe("Recipe 3"),
                new Recipe("Recipe 4")
            };

        
        
            recipeListBox.ItemsSource = recipes;
        }

        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
         
            selectedRecipe = (Recipe)recipeListBox.SelectedItem;
            DisplaySelectedRecipe();
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
           
           
            string name = ingredientNameTextBox.Text;
            string quantity = ingredientQuantityTextBox.Text; double dblquantity = Convert.ToDouble(quantity);
            string unit = ingredientUnitTextBox.Text;

            selectedRecipe.AddIngredient(name, dblquantity, unit);
            RefreshIngredientsList();
        }

        private void RemoveIngredientButton_Click(object sender, RoutedEventArgs e)
        {
           
           
            Ingredient selectedIngredient = (Ingredient)ingredientsListBox.SelectedItem;

            if (selectedIngredient != null)
            {
                selectedRecipe.RemoveIngredient(selectedIngredient);
                RefreshIngredientsList();
            }
        }

        private void AddStepButton_Click(object sender, RoutedEventArgs e)
        {
           
           
            string description = stepDescriptionTextBox.Text;

            selectedRecipe.AddStep(description);
            RefreshStepsList();
        }

        private void RemoveStepButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            Step selectedStep = (Step)stepsListBox.SelectedItem;

            if (selectedStep != null)
            {
                selectedRecipe.RemoveStep(selectedStep);
                RefreshStepsList();
            }
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = recipeNameTextBox.Text;

          
          
            if (!string.IsNullOrEmpty(recipeName))
            {
                
                
                Recipe newRecipe = new Recipe(recipeName);

             
             
                recipeListBox.Items.Add(newRecipe);


                recipeNameTextBox.Text = string.Empty;
            }
        }


        private void DeleteRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)recipeListBox.SelectedItem;

            if (selectedRecipe != null)
            {
                recipes.Remove(selectedRecipe);
                ClearRecipeDetails();
                recipeListBox.ItemsSource = null;
                recipeListBox.ItemsSource = recipes;
            }
        }


        private void DisplaySelectedRecipe()
        {
           
           
            if (selectedRecipe != null)
            {
                selectedRecipeTextBlock.Text = selectedRecipe.Name;
                RefreshIngredientsList();
                RefreshStepsList();
                totalCaloriesTextBlock.Text = selectedRecipe.TotalCalories.ToString();
            }
        }

        private void RefreshIngredientsList()
        {
       
       x
            ingredientsListBox.ItemsSource = null;
            ingredientsListBox.ItemsSource = selectedRecipe.Ingredients;
        }

        private void RefreshStepsList()
        {
      
      
            stepsListBox.ItemsSource = null;
            stepsListBox.ItemsSource = selectedRecipe.Steps;
        }

        private void ClearRecipeDetails()
        {
           
           
            selectedRecipeTextBlock.Text = string.Empty;
            ingredientNameTextBox.Text = string.Empty;
            ingredientQuantityTextBox.Text = string.Empty;
            ingredientUnitTextBox.Text = string.Empty;
            stepDescriptionTextBox.Text = string.Empty;
            totalCaloriesTextBlock.Text = string.Empty;
            ingredientsListBox.ItemsSource = null;
            stepsListBox.ItemsSource = null;
        }
        private void ScaleRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)recipeListBox.SelectedItem;

            if (selectedRecipe != null)
            {
                ScaleRecipe(selectedRecipe);
                totalCaloriesTextBlock.Text = "Total Calories: " + CalculateTotalCalories(selectedRecipe);
            }
        }

        private void ResetRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)recipeListBox.SelectedItem;

            if (selectedRecipe != null)
            {
                ResetRecipeToPreviousState(selectedRecipe);
                ClearRecipeDetails();
                recipeListBox.ItemsSource = null;
                recipeListBox.ItemsSource = recipes;
            }
        }


        

        private void ScaleRecipe(Recipe recipe)
        {
            void ScaleIngredients(double scale, List<Ingredient> ingredients)
            {
                foreach (var ingredient in ingredients)
                {
                    ingredient.Quantity *= scale;
                }
            }

            if (scaleComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string scaleOption = selectedItem.Content.ToString();

                if (double.TryParse(scaleOption, out double scale))
                {
                    ScaleIngredients(scale, recipe.Ingredients);
                    recipe.Scale = scale;
                }
            }
        }





        private void ResetRecipeToPreviousState(Recipe recipe)
        {
            void ResetIngredients(List<Ingredient> ingredients,Recipe recipe)
            {
                foreach (var ingredient in ingredients)
                {
                    ingredient.Quantity /= recipe.Scale;
                }
            }

            ResetIngredients(recipe.Ingredients,recipe);
            recipe.Scale = 1.0;
        }



        private double CalculateTotalCalories(Recipe recipe)
        {
            double totalCalories = 0;

            foreach (var ingredient in recipe.Ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            return totalCalories;
        }

    }
}
