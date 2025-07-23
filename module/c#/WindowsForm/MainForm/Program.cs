using System;
using System.Windows.Forms;

namespace WindowsFormTest
{
	/// <summary>
	/// Program 的摘要说明。
	/// </summary>
	public class Program
	{
		public Program()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmMain());
		}

	}
}
