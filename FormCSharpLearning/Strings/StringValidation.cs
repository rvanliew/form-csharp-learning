using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormCSharpLearning.Strings
{
    public static class StringValidation
    {
        public static List<CustomerDataModel> GetCustomerDataFromCsvFile()
        {
            // instantiate a new list of type DataModel
            List<CustomerDataModel> csvData = new List<CustomerDataModel>();

            // try catch block will help the program fail gracefully and allow the program to continue running even in the event of an error
            try
            {
                // StreamReader will open a file into RAM memory and read it
                // This code will not work if the file is already open on your computer
                using (var streamReader = new StreamReader(@"C:\us-500.csv"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        CustomerDataModel dataModel;

                        string[] values = line.Split(',');
                        if(values.Count() == 12)
                        {
                            dataModel = new CustomerDataModel()
                            {
                                FirstName = values[0],
                                LastName = values[1],
                                CompanyName = values[2],
                                Address = values[3],
                                City = values[4],
                                County = values[5],
                                State = values[6],
                                Zip = values[7],
                                PhoneOne = values[8],
                                PhoneTwo = values[9],
                                Email = values[10],
                                Website = values[11]
                            };
                        }
                        else
                        {
                            dataModel = new CustomerDataModel()
                            {
                                FirstName = values[0],
                                LastName = values[1],
                                CompanyName = $"{values[2]} {values[3]}",
                                Address = values[4],
                                City = values[5],
                                County = values[6],
                                State = values[7],
                                Zip = values[8],
                                PhoneOne = values[9],
                                PhoneTwo = values[10],
                                Email = values[11],
                                Website = values[12]
                            };
                        }

                        csvData.Add(dataModel);
                    }
                }

                // remove header row
                csvData.RemoveAt(0);

                // return our newly created list of data
                return csvData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static string GetLastName(string fullName)
        {
            string[] fullNameArray = fullName.Split(' ');
            string firstName = fullNameArray[0];
            string lastName = fullNameArray[1];

            return lastName;
        }

        public static string GetEmailSuffix(string email) //myemailaddress@gmail.com
        {
            string toBeSearched = "@";
            string suffix = email.Substring(email.IndexOf(toBeSearched) + toBeSearched.Length);

            return suffix;
        }

        public static string GetEmailPrefix(string email)
        {
            string[] emailAddressArray = email.Split('@');
            string prefix = emailAddressArray[0];
            string suffix = emailAddressArray[1];

            return prefix;
        }
    }
}
