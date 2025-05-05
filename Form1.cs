using ThomureWeek8Task1.DatabaseHandler;

namespace ThomureWeek8Task1
{
    public partial class Form1 : Form
    {
        private String spacing = "                        ";//24 spaces
        List<FridgeType> fridgeList = new List<FridgeType>();
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh_Page()
        {
            FridgeContentsListBox.Items.Clear();
            foreach (FridgeType tuple in fridgeList)
            {
                FridgeContentsListBox.Items.Add(String.Format("{0,-19}{1,-21}{2}", tuple.Name, tuple.ExpirationDate, tuple.Units));
            }

            GroceryListBox.Items.Clear();
            foreach (FridgeType tuple in fridgeList)
            {
                if (tuple.Minimum > tuple.Units)
                {
                    GroceryListBox.Items.Add(String.Format("{0,-29}{1}", tuple.Name, tuple.Minimum - tuple.Units));
                }
            }
        }

        private void update_Page()
        {
            refresh_Page();
            FridgeDatabaseHandler.Save(fridgeList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fridgeList = FridgeDatabaseHandler.Load();
            refresh_Page();

        }

        private void UpdateFridgeContentsSubmitButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fridgeList.Count; i++) //foreach could have been better, but I need to find the placement on the list
            {
                if (FridgeContentsListBox.GetItemChecked(i))
                {
                    fridgeList[i].Units -= (int)UpdateFridgeContentsNumeric.Value;
                }
            }
            update_Page();
        }

        private void AddNewItemsSubmitButton_Click(object sender, EventArgs e)
        {
            fridgeList.Add(new FridgeType(AddNewItemsNameText.Text, DateOnly.FromDateTime(AddNewItemsExpirationDate.Value),
                (int)AddNewItemsInitialUnitsNumeric.Value));
            update_Page();
        }

        private void DeleteSubmitButton_Click(object sender, EventArgs e)
        {
            int fridgeListIndex = 0;
            while (GroceryListBox.CheckedItems.Count > 0 && fridgeListIndex < fridgeList.Count)
            {
                String[] tuple = GroceryListBox.CheckedItems[0].ToString().Split(" ", 2);
                if (fridgeList[fridgeListIndex].Name == tuple[0]
                    && fridgeList[fridgeListIndex].Minimum - fridgeList[fridgeListIndex].Units == int.Parse(tuple[1]))
                {
                    fridgeList.RemoveAt(fridgeListIndex);
                    GroceryListBox.Items.RemoveAt(GroceryListBox.CheckedIndices[0]);
                    FridgeContentsListBox.Items.RemoveAt(fridgeListIndex);
                }
                fridgeListIndex++;
            }

            while (FridgeContentsListBox.CheckedItems.Count > 0)
            {
                fridgeList.RemoveAt(FridgeContentsListBox.CheckedIndices[0]);
                FridgeContentsListBox.Items.RemoveAt(FridgeContentsListBox.CheckedIndices[0]);
            }

            update_Page();
        }

        private void GroceryListAlarmCreatorSubmitButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fridgeList.Count; i++)
            {
                if (FridgeContentsListBox.GetItemChecked(i))
                {
                    fridgeList[i].Minimum = (int)GroceryListAlarmCreatorNumeric.Value;
                }
            }
            update_Page();
        }
    }
}