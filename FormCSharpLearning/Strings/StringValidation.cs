using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FormCSharpLearning.Strings
{
    public static class StringValidation
    {
        public static List<DataModel> GetCustomerDataFromCsvFile()
        {
            // instantiate a new list of type DataModel
            List<DataModel> csvData = new List<DataModel>();

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
                        var values = line.Split(',');

                        DataModel dataModel = new DataModel()
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
            var namesSplit = fullName.Split(' ');
            string firstName = namesSplit[0];
            string lastName = namesSplit[1];

            return lastName;
        }
    }
}
