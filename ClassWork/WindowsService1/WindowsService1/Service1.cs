using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        FileWriter writer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            writer = new FileWriter();
            writer.Write("Service started at " + DateTime.Now.ToString());
        }
        protected override void OnShutdown()
        {
            writer.Write("Shutdown " + DateTime.Now.ToString());
            base.OnShutdown();
        }

        protected override void OnStop()
        {
            writer.Write("Stop " + DateTime.Now.ToString());

        }
    }
}
