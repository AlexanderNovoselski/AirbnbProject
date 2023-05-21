using Airbnb.Apartment.Three.BusinessLayer;
using System.Diagnostics;
using System.Windows.Forms;

namespace Airbnb.Apartment.Three.Layot
{
    public partial class Form1 : Form
    {
        private IItemRepository _itemRepository = new ItemRepository();
        private bool isListDisplayed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var itemName = ItemBox.Text;
                var quantity = int.Parse(QuantityBox.Text);
                var price = double.Parse(PriceTextBox.Text);
                var boughtFrom = BoughtItemBox.Text;
                MessageBox.Show(_itemRepository.Create(itemName, quantity, price, boughtFrom));
                _itemRepository.UpdateTotalSum();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                double totalSum = _itemRepository.GetTotalSum();
                SumTextBox.Text = totalSum.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isListDisplayed)
                {
                    var items = _itemRepository.GetItems();
                    foreach (var item in items)
                    {
                        ListBox.Items.Add(item);
                    }
                    AvailableItemsButton.Text = "Off";
                    isListDisplayed = true;
                }
                else
                {
                    ListBox.Items.Clear();
                    AvailableItemsButton.Text = "On";
                    isListDisplayed = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}