using ice_task_1_indexes;

public class Program
{
    public static void Main(string[] args)
    {
        CakeRecipeTree recipeTree = new CakeRecipeTree();

        // Adding recipes with ingredients
        recipeTree.AddRecipe(new string[] { "flour", "sugar", "eggs", "vanilla essence" }, "Vanilla Cake");
        recipeTree.AddRecipe(new string[] { "flour", "sugar", "eggs", "cocoa powder" }, "Chocolate Cake");
        recipeTree.AddRecipe(new string[] { "flour", "sugar", "eggs","buttermilk", "red food colouring" }, "Red Velvet Cake");
        recipeTree.AddRecipe(new string[] { "flour", "sugar", "eggs", "buttermilk", "vanilla essence" }, "Sponge Cake");
        recipeTree.AddRecipe(new string[] { "flour", "sugar", "eggs", "butter", "melted chocolate" }, "Brownies");

        // Search for vanilla cake
        Console.WriteLine("Recipes for 'flour', 'sugar', 'eggs' and 'vanilla':");
        List<string> recipes = recipeTree[new string[] { "flour", "sugar", "eggs", "vanilla" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        // Search for chocolate cake
        Console.WriteLine("\nRecipes for 'flour', 'sugar', 'eggs' and 'cocoa powder':");
        recipes = recipeTree[new string[] { "flour", "sugar", "eggs", "cocoa powder" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        // Search for red velvet cake
        Console.WriteLine("\nRecipes for 'flour', 'sugar', 'eggs', 'buttermilk' and 'red food colouring':");
        recipes = recipeTree[new string[] { "flour", "sugar","eggs", "buttermilk", "red food colouring" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        // Search for red sponge cake
        Console.WriteLine("\nRecipes for 'flour', 'sugar', 'eggs', 'buttermilk' and 'vanilla essence':");
        recipes = recipeTree[new string[] { "flour", "sugar", "eggs", "buttermilk", "vanilla essence" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        // Search for brownies
        Console.WriteLine("\nRecipes for 'flour', 'sugar', 'eggs', 'butter' and 'melted chocolate':");
        recipes = recipeTree[new string[] { "flour", "sugar", "eggs", "butter", "melted chocolate" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        // Search for carrot cake (not in the recipes list)
        Console.WriteLine("\nRecipes for 'flour', 'sugar', 'eggs', 'oil' and 'carrots':");
        recipes = recipeTree[new string[] { "flour", "sugar", "eggs", "oil", "carrots" }];
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }
    }
}