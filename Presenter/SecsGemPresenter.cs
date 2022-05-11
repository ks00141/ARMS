using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Service;

namespace ARMS.Presenter
{
    class SecsGemPresenter
    {
        readonly SecsGemService service;

        public SecsGemPresenter()
        {
            this.service = new SecsGemService();
        }

        public void SecsGemStart()
        {
            service.SecsGemStart();
        }
    }
}
