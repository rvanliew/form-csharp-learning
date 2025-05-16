using FormCSharpLearning.Strings;
using System.Collections.Generic;

namespace FormCSharpLearning.Collections
{
    public static class CollectionsSearch
    {
        public static List<CustomerDataModel> GetState(List<CustomerDataModel> database, string state)
        {
            List<CustomerDataModel> customerList = new List<CustomerDataModel>();
            foreach(CustomerDataModel customerData in database)
            {
                if (customerData.State.ToUpper().Equals(state.ToUpper()))
                {
                    customerList.Add(customerData);
                }
            }

            return customerList;
        }
    }
}
