using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.View;
using ARMS.Service;
using ARMS.Model;

namespace ARMS.Presenter
{
    public class PpidPresenter
    {
        private readonly IPpidListView view;
        public PpidPresenter(IPpidListView view)
        {
            this.view = view;
        }

        public void PrintAllPpid()
        {
            PpidService service = new PpidService();
            foreach(RecipePpid ppid in service.CheckAll())
            {
                view.Ppid = new string[] { ppid.Device, ppid.Ppid };
            }
        }

        public void PrintPpidByDevice(string device)
        {
            PpidService service = new PpidService();
            foreach (RecipePpid ppid in service.CheckByDevice(device))
            {
                view.Ppid = new string[] { ppid.Device, ppid.Ppid };
            }
        }
    }
}
