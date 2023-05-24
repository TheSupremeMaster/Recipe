using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
//DO NOT USE THIS CLASS'

namespace Assignment4
{
    public partial class FormMain
    {
       
      public FormMain()
      {//
          InitializeComponent();
            RecipeManager();
      }
      private void RecipeManager()
      {
         Recipe;
            Max number of ingredients = 50;
            Max number of recipes = 200;
      }
      private void Recipe()
      {

      }
      private void addIngredients()
      {

      }
      private void removeIngredients() 
      { 

      }
      private void InitializeComponent()
      {

      }
      private void btnAddIngredient_Click(object sender, EventArgs e)
      {

      }
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleate_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
        private void ClearSection()
        {

        }
        private void InitializeGIU()
        {

        }
        private void lstRecipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void lstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateGUI()
        {

        }
    }
  public partial class MainForm
  {
        MainForm();
      class ingredients
      {
          public ingreients()
          {

          }
      }
      private void btnAddIngredient_Click(object sender, EventArgs e)
      {
          MainForm dlg = new FormIngredients(currRecipe);
          DialogResult dlgResult = dlg.showDialog();
          if(currRecipe.CurrentNumberOfIngreduents()<=0)
          {
              MessageBox.Show("No ingredients specified", "Error");
          }
      }


      public class RecipeManager
      {
            Recipe();
          public RecipeManager(int maxNumOfElements)
          {
              recipeList = new Recipe[maxNumOfElements];
          }
      }


      public void recipeList()
      {

      }
      public void Recipe()
      {
            FoodCategory();
      }
      string RecipeDescription()
      {

      }
        public void FoodCategory()
        {
            string ingredients;
        }
  }
}
