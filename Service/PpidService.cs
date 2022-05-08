using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Repository;

namespace ARMS.Service
{
    class PpidService
    {
        public ArrayList CheckAll()
        {
            return new PpidRepository().FindAllPpid();
        }

        public ArrayList CheckByDevice(string device)
        {
            return new PpidRepository().FindByDevice(device);
        }
    }
}
