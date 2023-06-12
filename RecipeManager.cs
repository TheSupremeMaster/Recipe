using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class RecipeManager
    {
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }
        public bool AddRecipe(Recipe recipe)
        {
            bool ok = true;
            int vacanPos = FindVacantPos();
            if (vacanPos != -1)
            {
                recipeList[vacanPos] = recipe;
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        public bool ChangeRecipeAt(int index, Recipe recipe)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                recipeList[index] = recipe;
                ok = true;
            }
            return ok;
        }
        public bool DeleateRecipetAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                recipeList[index] = null;
                MoveElementOneStepLeft(index);
                ok = true;
            }
            return ok;
        }
        bool CheckIndex(int index)
        {
            return (index >= 0) && (index < recipeList.Length);
        }
        private void MoveElementOneStepLeft(int index)
        {
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i];
                recipeList[i] = null;
            }
        }
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] == null)
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }
        private int NumOfRecipes()
        {
            int numRecipes = 0;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    numRecipes++;
                }
            }
            return numRecipes;
        }
        public int Count
        {
            get { return NumOfRecipes(); }
        }

        public string[] GetRecipeListToString()
        {
            int size = NumOfRecipes();
            if (size <= 0)
                return null;
            string[] recipes = new string[size];
            for (int i = 0, j = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    recipes[j++] = recipeList[i].ToString();
                }
            }
            return recipes;
        }
        public double CalcTotalIngreditents()
        {
            int numOfIngredients = NumOfRecipes();
            double totalIngredients = numOfIngredients * NumOfRecipes();
            return totalIngredients;
        }
    }
}