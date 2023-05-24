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

        // Create a bool method AddRecipe
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

        // Create a bool method ChangeAt
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
        // Create a bool method DeleteAt
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
        // Create a bool method CheckIndex
        bool CheckIndex(int index)
        {
            return (index >= 0) && (index < recipeList.Length);
        }

        // Create a private void method MoveElementsOneStepLeft
        private void MoveElementOneStepLeft(int index)
        {
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i];
                recipeList[i] = null;
            }
        }

        // Create an int method FindVacantPos
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }

    }
}
