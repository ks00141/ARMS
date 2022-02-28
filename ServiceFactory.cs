using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS
{
    class ServiceFactory
    {
        dynamic userForm;
        public ServiceFactory(dynamic form)
        {
            this.userForm = form;
        }
        public SecsService getService()
        {
            return new SecsService(userForm);
        }
    }
}