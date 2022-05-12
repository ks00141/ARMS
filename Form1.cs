using ARMS.Presenter;
using ARMS.View;
using log4net;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ARMS
{
    public partial class Form1 : Form, IPpidListView, IRecipeParamUPloadView
    {
        SecsGemPresenter secsGemPresenter;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");

        public string[] Ppid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClusterRecipe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FrontsideRecipe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionDies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionColumns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionRows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Form1()
        {
            InitializeComponent();
            this.secsGemPresenter = new SecsGemPresenter(this);
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            try
            {
                secsGemPresenter.SecsGemStart();
            }
            catch (Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }
    }
}
