using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public bool DeleateIngridient(int index)
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
        bool CheckIndex(int index)
        {
            return (index>=0) && (index<Ingredients.Length);
        }
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
        private void MoveElementOneStepLeft(int index)
        {
            for(int i=index+1;i<ingredients.Length; i++)
            {
                ingredients[i-1] = ingredients[i];
                ingredients[i] = null;
            }
        }
        // Follow the steps from screenshot
        // Change guestList to ingredients here
        public int CurrentNumberOfIngredients()
        {
            int numOfIngredients = 0;
            for(int i=0;i<ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                {
                    numOfIngredients++;
                }
            }
            return numOfIngredients;
        }
        private int NumOfIngredients()
        {
            int numIngredients = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                {
                    numIngredients++;
                }
            }
            return numIngredients;
        }
        public int Count
        {
            get { return NumOfIngredients(); }
        }
        public double CalcTotalIngreditents()
        {
            int numOfIngredients = NumOfIngredients();
            double totalIngredients = numOfIngredients * NumOfIngredients();
            return totalIngredients;
        }

        // Create a method returns string array
        // Follow the steps from page 9 in the help document for grade C
        public string[] GetIngredientList()
        {
            int size = CurrentNumberOfIngredients();
            if(size <= 0)
                return null;
            string[] ingredients = new string[size];
            for(int i=0,j=0;i<ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                {
                    ingredients[j++] = ingredients[i];
                }
            }
            return ingredients;
        }
        public int MaxNumOfIngredients
        {
            get { return MaxNumOfIngredients; }
        }

        public override string ToString()
        {
            // Use the variables for food category and number of ingredients and
            // write in the "  " with curly bracket below
            string strOut = $"{name}  ";
            return strOut;
        }


    }
}
