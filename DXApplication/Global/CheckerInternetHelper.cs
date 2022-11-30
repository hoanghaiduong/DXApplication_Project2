using NETWORKLIST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DXApplication;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Svg;

namespace DXApplication.Global
{
    public class CheckerInternetHelper:INetworkListManagerEvents
    {
        private int m_cookie = 0;
        private IConnectionPoint m_icp;
        private INetworkListManager m_nlm;
        public Frm_Dashboard frm_Dashboard;
        

        public INetworkListManager Nlm { get => m_nlm; }
        public IConnectionPoint Icp { get => m_icp;}

        public CheckerInternetHelper(Frm_Dashboard frm_Dashboard)
        {
            m_nlm = new NetworkListManager();
            this.frm_Dashboard = frm_Dashboard;
        }
        public void SetText(string message, Color color, Color color2)
        {
          
        }
        public void ConnectivityChanged(NLM_CONNECTIVITY newConnectivity)
        {
            if (newConnectivity == NLM_CONNECTIVITY.NLM_CONNECTIVITY_DISCONNECTED)
            {
                SetText("Đã ngắt kết nối internet!", Color.White, Color.Red);
                MessageBox.Show("Đã ngắt kết nối internet!");
            }
            if (((int)newConnectivity & (int)NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV4_INTERNET) != 0)
            {
                SetText("Đang kết nối thành công Internet với IPv4!", Color.White, Color.Green);
                MessageBox.Show("Đang kết nối thành công Internet với IPv4!");
            }
            if (((int)newConnectivity & (int)NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV6_INTERNET) != 0)
            {
                SetText("Đang kết nối thành công Internet với IPv6!", Color.White, Color.Green);
                MessageBox.Show("Đang kết nối thành công Internet với IPv6!");
            }
            if ((((int)newConnectivity & (int)NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV4_INTERNET) == 0)
                && (((int)newConnectivity & (int)NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV6_INTERNET) == 0))
            {
                SetText("Mất kết nối Internet!", Color.White, Color.Red);
                MessageBox.Show("Mất kết nối Internet!");
            }
        }
        //hàm đăng kí kết nối mạng
        public void AdviseforNetworklistManager()
        {
            IConnectionPointContainer icpc = (IConnectionPointContainer)m_nlm;
            Guid tempGuid = typeof(INetworkListManagerEvents).GUID;
            icpc.FindConnectionPoint(ref tempGuid, out m_icp);
            Icp.Advise(this, out m_cookie);
        }
        //hàm hủy đăng kí kết nối mạng
        public void UnAdviseforNetworklistManager()
        {
            try
            {
               // Icp.Unadvise(m_cookie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
