using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice_task_1_indexes
{
    public class CakeRecipeTree
    {
        private CakeRecipeTreeNode root;

        // Constructor to that allows the application to initialize the CakeRecipeNode
        public CakeRecipeTree()
        {
            root = new CakeRecipeTreeNode("");
        }

        // Method to add a recipe based on ingredients
        public void AddRecipe(string[] ingredients, string recipe)
        {
            CakeRecipeTreeNode currentNode = root;

            foreach (string ingredient in ingredients)
            {
                if (!currentNode.Children.ContainsKey(ingredient))
                {
                    currentNode.Children[ingredient] = new CakeRecipeTreeNode(ingredient);
                }

                currentNode = currentNode.Children[ingredient];
            }

            currentNode.Recipes.Add(recipe);
        }

        // Indexer to search for recipes based on ingredients specified by the user
        public List<string> this[string[] ingredients]
        {
            get
            {
                CakeRecipeTreeNode currentNode = root;

                foreach (string ingredient in ingredients)
                {
                    if (!currentNode.Children.ContainsKey(ingredient))
                    {
                        // No recipe matches the given ingredients
                        return new List<string> 
                        { "There were no recipes found, please try again using different ingredients" };
                    }

                    currentNode = currentNode.Children[ingredient];
                }

                return currentNode.Recipes.Count > 0 ? currentNode.Recipes : new List<string> 
                { "There were no recipes found, please try again using different ingredients" };
            }
        }
    }
}
