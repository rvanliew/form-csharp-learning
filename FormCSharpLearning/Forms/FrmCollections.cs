using FormCSharpLearning.Collections;
using FormCSharpLearning.Strings;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormCSharpLearning.Forms
{
    public partial class FrmCollections : Form
    {
        private List<CustomerDataModel> _database = new List<CustomerDataModel>();

        public FrmCollections()
        {
            InitializeComponent();
            _database = StringValidation.GetCustomerDataFromCsvFile();
        }

        private void btnGetCustomerCount_Click(object sender, System.EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbState.Text))
            {
                return;
            }

            // creating a new List of Customer Data Model
            // CustomerDataModel is the Type
            // So List<Of Type> followed by the variable name for the list
            // we then call the GetState Method that derives from our static class CollectionsSearch
            // passing in our database variable and the state we are searching for
            List<CustomerDataModel> customerList = CollectionsSearch.GetState(_database, tbState.Text);

            // displaying the list count (how many customers are in the list)
            tbCustomerListCount.Text = customerList.Count.ToString();

            // passing in our newly created list to display ALL of the customers inside the list
            DisplayCustomerData(customerList);
        }

        private void DisplayCustomerData(List<CustomerDataModel> customerDataList)
        {
            // string builder used to display customer data
            // stringbuilder is essentially a list of strings with certain formatting
            StringBuilder sb = new StringBuilder();

            //taking customerDataList (parameter) and creating a new sortedList variable to loop over
            // the sorted list is being sorted by LastName
            // => refers to what we call a Lamda expression. It's essentially a variable name followed by a period followed by the property youre looking for
            List<CustomerDataModel> sortedList = customerDataList.OrderBy(name => name.LastName).ToList();

            //looping over the SORTEDLIST then adding each customer to the stringbuilder
            foreach (CustomerDataModel customerData in sortedList)
            {
                // appendLine will display customer data then add a new line
                sb.AppendLine($"{customerData.LastName} {customerData.FirstName}");
            }

            // setting textbox text to stringbuilder
            tbCustomerDisplay.Text = sb.ToString();
        }
    }
}
