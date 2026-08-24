using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace PCodeFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                AutoResetEvent waitHandle = new AutoResetEvent(false);
                workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) { waitHandle.Set(); };
                workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
                {
                    Console.WriteLine(e.Exception.Message);
                    waitHandle.Set();
                };

                Dictionary<string, object> wfArgs = new Dictionary<string, object>();
                wfArgs.Add("PostalCode", args.Length > 0 ? args[0] : "");

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(PCodeFlow.Workflow1), wfArgs);
                instance.Start();

                waitHandle.WaitOne();
            }
        }
    }
}
