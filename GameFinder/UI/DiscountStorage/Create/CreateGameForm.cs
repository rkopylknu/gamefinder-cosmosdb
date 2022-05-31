using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameFinder.UI.DiscountStorage.Create
{
    public partial class CreateGameForm : Form
    {
        private CreateGameViewModel viewModel;

        public CreateGameForm(CreateGameViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;

            DialogResult = DialogResult.No;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string name = tbName.Text;
            string manufacturer = tbManufacturer.Text;
            string store = tbStore.Text;
            List<string> genres = tbGenres.Text.Split(',').ToList();
            int year = (int)numYear.Value;
            int price = int.Parse(tbPrice.Text);
            List<string> languages = tbLanguages.Text.Split(',').ToList();
            int count = (int)numCount.Value;

            viewModel.CreateGame(
                name, manufacturer, store, genres, year, price, languages, count
            );

            MessageBox.Show(
                "Game was created successfully",
                "Created",
                MessageBoxButtons.OK
            );
            DialogResult = DialogResult.Yes;
            Close();
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                gbName.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbName.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbManufacturer.Text))
            {
                gbManfucturer.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbManfucturer.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbStore.Text))
            {
                gbStore.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbStore.ForeColor = Color.Black;
            }
            if ((int)numYear.Value < 1901 || (int)numYear.Value > 9999)
            {
                lbYear.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lbYear.ForeColor = Color.Black;
            }
            if (!int.TryParse(tbPrice.Text, out _))
            {
                gbPrice.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                gbPrice.ForeColor = Color.Black;
            }
            if ((int)numCount.Value < 1)
            {
                lbCount.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lbCount.ForeColor = Color.Black;
            }

            return isValid;
        }
    }
}
