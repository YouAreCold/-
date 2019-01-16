using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using XKY.HIS.Login.Library;

namespace XKY.HIS.Login.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			// 通过反射调用窗体  参数：命名空间+窗体名称
			Type typeLoginForm = Assembly.GetExecutingAssembly().GetType("XKY.HIS.Login.UI.FrmLoginNew");
			if (null != typeLoginForm)
			{
				// 强制为窗体
				frmLoginForm =(Form)Activator.CreateInstance(typeLoginForm);
				if (null != frmLoginForm) break;
			}       
            Application.Run(frmLoginForm);
        }
    }
}
