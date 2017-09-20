using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.Code
{
    public static class Validation
    {
        const string key_empty = "empty";
        const string key_name_operation = "wrong_operation_name";
        const string key_name_format = "wrong_name_format";
        const string key_number_format = "wrong_number_format";
        const string key_number_value = "wrong_number_value";
        public static void displayMessage(string value)
        {
            switch (value)
            {
                case "empty":
                    Console.WriteLine("You have to insert value.");
                    break;
                case "wrong_operation_name":
                    Console.WriteLine("Please insert appropriate operation.");
                    break;
                case "wrong_name_format":
                    Console.WriteLine("Name is not in an appropriate format.");
                    break;
                case "wrong_number_format":
                    Console.WriteLine("Number is not in an appropriate format.");
                    break;
                case "wrong_number_value":
                    Console.WriteLine("Number is not in the correct range.");
                    break;
            }
        }
        public static bool validateName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                displayMessage(key_empty);
                return false;
            }
            else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                displayMessage(key_name_format);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool validateOperationName(string operation)
        {
            if (string.IsNullOrEmpty(operation))
            {
                displayMessage(key_empty);
                return false;
            }
            else if (operation.ToLower() != Operations.operationDisplay && operation.ToLower() != Operations.operationEnlist)
            {
                displayMessage(key_name_operation);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool validateGPA(string value)
        {
            float gpa;
            if (string.IsNullOrEmpty(value))
            {
                displayMessage(key_empty);
                return false;
            }
            else if(!float.TryParse(value,out gpa)) {
                displayMessage(key_number_format);
                return false;
            }
            else if(gpa<1 || gpa > 5)
            {
                displayMessage(key_number_value);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

