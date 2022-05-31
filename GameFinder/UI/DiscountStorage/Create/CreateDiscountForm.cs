using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameFinder.UI.DiscountStorage.Create
{
    public partial class CreateDiscountForm : Form
    {
        private CreateDiscountViewModel viewModel;

        public CreateDiscountForm(CreateDiscountViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;

            DialogResult = DialogResult.No;
        }

        private void btnFindGame_Click(object sender, EventArgs e)
        {
            if (!ValidateFindGameInput()) return;

            string gameName = tbGameName.Text;
            string gameManufacturer = tbGameManufacturer.Text;
            string gameStore = tbGameStore.Text;

            if (viewModel.TrySelectGame(gameName, gameManufacturer, gameStore))
            {
                lbRegularPrice.Text = viewModel.GetGamePrice().ToString();
                gbNewPrice.Enabled = true;
                btnCreate.Enabled = true;
            } 
            else
            {
                MessageBox.Show(
                    "Game was not found",
                    "Not Found",
                    MessageBoxButtons.OK
                );
                lbRegularPrice.Text = string.Empty;
                tbNewPrice.Text = string.Empty;
                gbNewPrice.Enabled = false;
                btnCreate.Enabled = false;
            }
            
        }
        
        private bool ValidateFindGameInput()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(tbGameName.Text))
            {
                gbGameName.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbGameName.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbGameManufacturer.Text))
            {
                gbGameManfucturer.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbGameManfucturer.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbGameStore.Text))
            {
                gbGameStore.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbGameStore.ForeColor = Color.Black;
            }
            return isValid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateCreateDiscountInput()) return;

            int newPrice = int.Parse(tbNewPrice.Text);

            if(viewModel.CreateDiscount(newPrice))
            {
                MessageBox.Show(
                    "Discount was created successfully",
                    "Created",
                    MessageBoxButtons.OK
                );
                DialogResult = DialogResult.Yes;
                Close();
            } 
            else
            {
                MessageBox.Show(
                    "Discount on this game already exists!",
                    "Cancelation",
                    MessageBoxButtons.OK
                );
            }
        }

        private bool ValidateCreateDiscountInput()
        {
            bool isValid = true;
            if (!int.TryParse(tbNewPrice.Text, out _))
            {
                gbNewPrice.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbNewPrice.ForeColor = Color.Black;
            }
            return isValid;
        }
    }
}
