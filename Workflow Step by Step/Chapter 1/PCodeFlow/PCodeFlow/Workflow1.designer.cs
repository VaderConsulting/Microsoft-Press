using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace PCodeFlow
{
    partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("", "")]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            this.FalseActivity = new System.Workflow.Activities.CodeActivity();
            this.TrueActivity = new System.Workflow.Activities.CodeActivity();
            this.FalseActivityEvaluation = new System.Workflow.Activities.IfElseBranchActivity();
            this.TrueActivityEvaluation = new System.Workflow.Activities.IfElseBranchActivity();
            this.EvalPostalCode = new System.Workflow.Activities.IfElseActivity();
            // 
            // FalseActivity
            // 
            this.FalseActivity.Name = "FalseActivity";
            this.FalseActivity.ExecuteCode += new System.EventHandler(this.PostalCodeInvalid);
            // 
            // TrueActivity
            // 
            this.TrueActivity.Name = "TrueActivity";
            this.TrueActivity.ExecuteCode += new System.EventHandler(this.PostalCodeValid);
            // 
            // FalseActivityEvaluation
            // 
            this.FalseActivityEvaluation.Activities.Add(this.FalseActivity);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.EvaluatePostalCode);
            this.FalseActivityEvaluation.Condition = codecondition1;
            this.FalseActivityEvaluation.Name = "FalseActivityEvaluation";
            // 
            // TrueActivityEvaluation
            // 
            this.TrueActivityEvaluation.Activities.Add(this.TrueActivity);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.EvaluatePostalCode);
            this.TrueActivityEvaluation.Condition = codecondition2;
            this.TrueActivityEvaluation.Name = "TrueActivityEvaluation";
            // 
            // EvalPostalCode
            // 
            this.EvalPostalCode.Activities.Add(this.TrueActivityEvaluation);
            this.EvalPostalCode.Activities.Add(this.FalseActivityEvaluation);
            this.EvalPostalCode.Name = "EvalPostalCode";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.EvalPostalCode);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private CancellationHandlerActivity cancellationHandlerActivity2;
        private IfElseBranchActivity FalseActivityEvaluation;
        private IfElseBranchActivity TrueActivityEvaluation;
        private CodeActivity TrueActivity;
        private CodeActivity FalseActivity;
        private IfElseActivity EvalPostalCode;





    }
}
