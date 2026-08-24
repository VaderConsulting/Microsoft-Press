using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;

using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using System.Text.RegularExpressions;

namespace PCodeFlow
{
    public sealed partial class Workflow1 : SequentialWorkflowActivity
    {
        private string _Code = "string.Empty";
        private int RunCount = 0;

        public string PostalCode
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }

        public Workflow1()
        {
            InitializeComponent();
        }

        private void EvaluatePostalCode(object sender, ConditionalEventArgs e)
        {
            string USCode = @"^\d{5}(-\d{4})?$";
            string CanadianCode = @"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$";

            RunCount += 1;

            Console.WriteLine("Run Count: {0}", RunCount.ToString());

            bool USResult = Regex.IsMatch(_Code, USCode);
            bool CanadianResult = Regex.IsMatch(_Code, CanadianCode);

            Console.WriteLine("US Result: {0}", USResult.ToString());
            Console.WriteLine("Canadian Result: {0}", CanadianResult.ToString());

            e.Result = USResult || CanadianResult;
        }

        private void PostalCodeValid(object sender, EventArgs e)
        {
            Console.WriteLine("The postal code {0} is valid.", _Code);
        }

        private void PostalCodeInvalid(object sender, EventArgs e)
        {
            // This code is never run

            Console.WriteLine("The postal code {0} is *invalid*.", _Code);
        }
    }

}
