using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class CakeRecipeTreeNode
    {
        public string Ingredient { get; set; }
        public List<string> Recipes { get; set; }
        public Dictionary<string, CakeRecipeTreeNode> Children { get; set; }

        public CakeRecipeTreeNode(string ingredient)
        {
            Ingredient = ingredient;
            Recipes = new List<string>();
            Children = new Dictionary<string, CakeRecipeTreeNode>();
        }
    }
