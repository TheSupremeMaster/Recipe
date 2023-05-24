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
    //Draw the components on the MainForm
    //Declare an instance of RecipeManager in this MainForm class
    //Ask for help to check the status of your programming - project
    internal partial class FormIngredient : Form
    {
        private Recipe recipe;
        public FormIngredient(Recipe currRecipe)
        {
            InitializeComponent();
            recipe = currRecipe;
            if (string.IsNullOrEmpty(recipe.Name))
            {
                this.Text = "No recipe name -- add ingredients";

            }
            else
            {
                this.Text = recipe.Name + " -- add ingredients";
            }
            InitializeGUI();
        }
        public void InitializeGUI()
        {
            if (recipe.Ingredients==null) 
                recipe.Ingredients = new string[recipe.MaxNumberOfIngredients()];
            lstIngredients.Items.Clear();
            groupBox1.Text = " " + recipe.CurrentNumberOfIngredients().ToString();
            int count = recipe.CurrentNumberOfIngredients();
            for(int index = 0; index < count; index++)
            {
                if (!string.IsNullOrEmpty(recipe.Ingredients[index]))
                    lstIngredients.Items.Add(recipe.Ingredients[index]);
            }
        }
        public int MaxNumOfIngredients
        {
            get { return MaxNumOfIngredients; }
        }
        public Recipe Recipe
        {
            get { return recipe; }
            set
            {
                if(value!= null)
                    recipe = value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lstIngredients.Text))
            {
                bool ok = recipe.AddIngredient(lstIngredients.Text);
                if (ok)
                    UpdateGUI();
                else
                    MessageBox.Show("Maximum number of ingredients reached", "Error");
            }
            else
                MessageBox.Show("Please specify ingredient", "Error");
        }
        private void UpdateGUI()
        {
            lstIngredients.Text = string.Empty;
            InitializeGUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;
            string text = lstIngredients.Text;
            if(index !=-1 && !string.IsNullOrEmpty(text))
            {
                recipe.ChangeIngredientsAt(index, text);
            }
            UpdateGUI();
        }
        private void btnDeleate_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;
            if (index != -1)
            {
                recipe.DeleateIngredientAt(index);
            }
            UpdateGUI();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
