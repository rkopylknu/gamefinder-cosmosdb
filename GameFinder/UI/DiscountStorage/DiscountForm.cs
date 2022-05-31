using GameFinder.UI.DiscountStorage.Create;
using GameFinder.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameFinder.UI.DiscountStorage
{
    public partial class DiscountForm : Form
    {
        private DiscountViewModel viewModel;

        private CreateGameViewModel createGameViewModel;
        private CreateDiscountViewModel createDiscountViewModel;

        private INavigator navigator;

        public DiscountForm(
            INavigator _navigator, 
            DiscountViewModel _viewModel,
            CreateGameViewModel _createGameViewModel,
            CreateDiscountViewModel _createDiscountViewModel)
        {
            InitializeComponent();
            navigator = _navigator;
            viewModel = _viewModel;
            createGameViewModel = _createGameViewModel;
            createDiscountViewModel = _createDiscountViewModel;

            StyleDataGridViews();

            UpdateGamesView();
            UpdateDiscountsView();
        }

        private void UpdateGamesView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Game");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("Year");
            table.Columns.Add("Genres");
            table.Columns.Add("Languages");
            table.Columns.Add("Store");
            table.Columns.Add("Price");
            table.Columns.Add("Count");

            foreach (var game in viewModel.GetGames())
            {
                table.Rows.Add(game.ToStringArray());
            }

            dgvGames.DataSource = table;

            foreach (DataGridViewColumn column in dgvGames.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void UpdateDiscountsView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Game");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("Store");
            table.Columns.Add("Regular Price");
            table.Columns.Add("Discount Price");

            foreach (var gd in viewModel.GetGamesAndDiscounts())
            {
                table.Rows.Add(
                    gd.Game.Name,
                    gd.Game.Manufacturer,
                    gd.Game.Store,
                    gd.Game.Price,
                    gd.Discount.Price
                );
            }

            dgvDiscounts.DataSource = table;

            foreach (DataGridViewColumn column in dgvDiscounts.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnGoToSearch_Click(object sender, System.EventArgs e) =>
            navigator.Navigate(Destination.Search);

        private void btnIncreaseGameCount_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            viewModel.OnIncreaseGameCount(selectedGameIndex);
            UpdateGamesView();
        }

        private void btnDecreaseGameCount_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;
            viewModel.OnDecreaseGameCount(selectedGameIndex);
            UpdateGamesView();
        }

        private void btnCreateGame_Click(object sender, System.EventArgs e)
        {
            CreateGameForm createGameForm = new CreateGameForm(createGameViewModel);
            if (createGameForm.ShowDialog() == DialogResult.Yes)
            {
                UpdateGamesView();
            }
        }

        private void btnDeleteGame_Click(object sender, System.EventArgs e)
        {
            int selectedGameIndex = dgvGames.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this game?\n",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                viewModel.OnDeleteGame(selectedGameIndex);
                UpdateGamesView();
                UpdateDiscountsView();
            }
        }

        private void btnCreateDiscount_Click(object sender, EventArgs e)
        {
            CreateDiscountForm createDiscountForm = new CreateDiscountForm(createDiscountViewModel);
            if (createDiscountForm.ShowDialog() == DialogResult.Yes)
            {
                UpdateDiscountsView();
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            int selectedDiscountIndex = dgvDiscounts.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this discount?\n",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                viewModel.OnDeleteDiscount(selectedDiscountIndex);
                UpdateDiscountsView();
            }
        }

        private void StyleDataGridViews()
        {
            DataGridView[] dgvs = { dgvGames, dgvDiscounts };

            foreach (var dgv in dgvs)
            {
                dgv.DefaultCellStyle.SelectionBackColor = Color.Honeydew;
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Honeydew;
            }
        }
    }
}
