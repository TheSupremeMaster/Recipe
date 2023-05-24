using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Recipe
    {
        private string name;
        private string description;
        private string[] ingredients;
        private FoodCategory foodCategory;

        // Have a parameter for constructor int maxNumOfIngredients
        // Create instance for string array of ingredients.
 
        // Create Constructor of Recipe below.
        public Recipe(int maxNumOfIngredients) 
        { 
            ingredients = new string[maxNumOfIngredients];
        }

        public string Name
        {
            get { return name; }
            set { name = value; }  
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Finish to create properties for FoodCategory and string array for ingredient.
        public FoodCategory FoodCategory 
        { 
            get { return foodCategory; }
            set { foodCategory = value; }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        // Methods

        // Have the methods for Add, Delete and Change ingredient.
        // Use same concept from PartyMAnager and change to your methods shown in class diagram page 9.

        // Create the private method FindVacantPos
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for(int index=0; index<Ingredients.Length; index++)
            {
                if (string.IsNullOrEmpty(Ingredients[index]))
                {
                    vacantPos = index; 
                    break;
                }
            }
            return vacantPos;
        }

        // Create the method AddIngredient.
        public bool AddIngredient(string ingredient)
        {
            bool ok = true;
            int vacanPos = FindVacantPos();
            if(vacanPos != -1)
            {
                ingredients[vacanPos] = ingredient;
            }
            else
            {
                ok= false;
            }
            return ok;
        }

        // Create a bool method CheckIndex
        bool CheckIndex(int index)
        {
            return (index>=0) && (index<Ingredients.Length);
        }

        // Create a bool method ChangeIngredientAt
        public bool ChangeIngredientAt(int index, string ingredient)
        {
            bool ok = false;
            if(CheckIndex(index))
            {
                Ingredients[index] = ingredient;
                ok = true;
            }
            return ok;
        }

        // Create a bool method DeleteIngredientAt
        public bool DeleateIngredientAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                Ingredients[index] = null;
                MoveElementOneStepLeft(index);
                ok = true;
            }
            return ok;
        }
        // Create a void method MoveElementOneStepLeft

        private void MoveElementOneStepLeft(int index)
        {
            for(int i=index+1;i<ingredients.Length; i++)
            {
                ingredients[i-1] = ingredients[i];
                ingredients[i] = null;
            }
        }


        // Create an int method CurrentNumberOfIngredients
        public int CurrentNumberOfIngredients()
        {
            int numOfIngredients = 0;


            return numOfIngredients;
        }
        public int MaxNumOfIngredients
        {
            get { return MaxNumOfIngredients; }
        }
    }
}
