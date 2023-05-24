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


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {

            FormIngredient dlg = new FormIngredient(currRecipe);
            
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
               
                if(currRecipe.CurrentNumberOfIngredients()<=0)
                {
                    MessageBox.Show("No ingredients specified", "Error");
                }
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStart_Click(object sender, EventArgs e)
        {

        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
