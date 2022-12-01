using DevExpress.XtraSplashScreen;
using System;

namespace DXApplication
{
    public partial class SplashScreenApp : SplashScreen
    {
        public SplashScreenApp()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}