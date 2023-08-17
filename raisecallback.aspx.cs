using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class race_callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnStart_Click(object sender, EventArgs e)
        {

            try {
                Func<string> taskA = new Func<string>(TaskA);
                Func<string> taskB = new Func<string>(TaskB);


                Action<string> onTaskComplete = new Action<string>(OnTaskComplete);


                RaceCallback(new Func<string>[] { taskA, taskB }, onTaskComplete);
            }
            catch (Exception ex) { }
            finally { }
          
            

        }

        private string TaskA()
        {
            Thread.Sleep(1000);
            return "Task A is done.";
        }

        private string TaskB()
        {
            Thread.Sleep(2000);
            return "Task B is done.";
        }

        private void OnTaskComplete(string result)
        {
            
            lblResult.Text = " callback result: "+ result;

        }

        private void RaceCallback(Func<string>[] tasks, Action<string> callback)
        {
            string[] results = new string[tasks.Length];

            ManualResetEvent callbacksDone = new ManualResetEvent(false);

            void TaskCallback(int index, string result)
            {
                if (!callbacksDone.WaitOne(0))
                {
                    results[index] = result;
                    callbacksDone.Set();
                    callback(result);
                }
            }



           
            for (int i = 0; i < tasks.Length; i++)
            {
                int index = i; 
                ThreadPool.QueueUserWorkItem(_ =>
                {
                    string result = tasks[index]();
                    TaskCallback(index, result);
                });
            }
        
    }
    }
}