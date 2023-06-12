using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    internal partial class MainForm : Form
    {
        private RecipeManager recipeManager;
        private Recipe currRecipe;
        private const int maxNumOfElements = 200;
        private const int maxNumOfIngredients = 50;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        public void InitializeGUI()
        {
            cmbBoxCategory.Items.Clear();
            cmbBoxCategory.Items.AddRange(Enum.GetNames(typeof(FoodCategory)));
            recipeManager = new RecipeManager(maxNumOfElements);
            currRecipe = new Recipe(maxNumOfIngredients);
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FormIngredient dlg = new FormIngredient(currRecipe);
            
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
                MessageBox.Show(currRecipe.CurrentNumberOfIngredients().ToString());
                if(currRecipe.CurrentNumberOfIngredients()<=0)
                {
                    MessageBox.Show("No ingredients specified", "Error");
                }
            }
        }

        // Create a void method UpdateGUI page 13 done
        private void UpdateGUI()
        {
            listBoxRecipes.Items.Clear();
            string[] recipes = recipeManager.GetRecipeListToString();
            if (recipes != null)
            {
                for (int i=0; i<recipes.Length; i++)
                {
                    string str = $"{i + 1,4}{recipes[i],-20}";
                    listBoxRecipes.Items.Add(str);
                }
            }
        }
        // Call the method GetRecipeListToString from recipeManager
 
        // Use the idea for assignment 4C help from page 13
        // Use from the row/line 130 to 141. Change guestList to recipeList and GetGuestList to GetRecipeListToString



        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            // Use same way you did for btnAdd in FormIngredient done
            // Get inputs for Recipe  by calling currRecipe done
            if (!string.IsNullOrEmpty(txtBoxName.Text))
            {
                currRecipe.Name = txtBoxName.Text;
                // Similar for description and food category done
                currRecipe.Description = txtBoxDescription.Text;
                currRecipe.FoodCategory = (FoodCategory)cmbBoxCategory.SelectedIndex;
                // Call the method AddRecipe from recipeManager. done
                bool ok = recipeManager.AddRecipe(currRecipe);
                if (ok)
                {
                    UpdateGUI();
                }
            }
        }

        private void btnEditStart_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipes.SelectedIndex;
            if (!string.IsNullOrEmpty(txtBoxName.Text))
            {
                currRecipe.Name = txtBoxName.Text;
                // Similar for description and food category done
                currRecipe.Description = txtBoxDescription.Text;
                currRecipe.FoodCategory = (FoodCategory)cmbBoxCategory.SelectedIndex;
                // Call the method AddRecipe from recipeManager. done
                bool ok = recipeManager.ChangeRecipeAt(index, currRecipe);
                if (ok)
                {
                    UpdateGUI();
                }
            }

        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipes.SelectedIndex;
            if (!string.IsNullOrEmpty(txtBoxName.Text))
            {
                currRecipe.Name = txtBoxName.Text;
                // Similar for description and food category done
                currRecipe.Description = txtBoxDescription.Text;
                currRecipe.FoodCategory = (FoodCategory)cmbBoxCategory.SelectedIndex;
                // Call the method AddRecipe from recipeManager. done
                bool ok = recipeManager.AddRecipe(currRecipe);
                if (ok)
                {
                    UpdateGUI();
                }
            }
        }

        private void btnDeleate_Click(object sender, EventArgs e)
        {
            int index = listBoxRecipes.SelectedIndex;
            if(index != -1)
            {
                recipeManager.DeleateRecipetAt(index);
                UpdateGUI();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
