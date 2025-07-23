using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormTest
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class FrmMain : System.Windows.Forms.Form
	{
		private int formNum;
		private ArrayList formTypes = new ArrayList();
		private ArrayList formObjects = new ArrayList();

		private System.Windows.Forms.MainMenu mnuMain;
		private System.Windows.Forms.MenuItem mnuItmRun;
		private System.Windows.Forms.MenuItem mnuItemWindow;
		private System.Windows.Forms.MenuItem mnuItmHelp;
		private System.Windows.Forms.MenuItem mnuItmCascade;
		private System.Windows.Forms.MenuItem mnuItmTileHorizontal;
		private System.Windows.Forms.MenuItem mnuItmTileVertical;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuItmAbout;
		private System.Windows.Forms.StatusBar staBarMain;
		private System.Windows.Forms.StatusBarPanel pnlInfo;
		private System.Windows.Forms.StatusBarPanel pnlNum;
        private IContainer components;

        public FrmMain()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuItmRun = new System.Windows.Forms.MenuItem();
            this.mnuItemWindow = new System.Windows.Forms.MenuItem();
            this.mnuItmCascade = new System.Windows.Forms.MenuItem();
            this.mnuItmTileHorizontal = new System.Windows.Forms.MenuItem();
            this.mnuItmTileVertical = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuItmHelp = new System.Windows.Forms.MenuItem();
            this.mnuItmAbout = new System.Windows.Forms.MenuItem();
            this.staBarMain = new System.Windows.Forms.StatusBar();
            this.pnlInfo = new System.Windows.Forms.StatusBarPanel();
            this.pnlNum = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNum)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItmRun,
            this.mnuItemWindow,
            this.mnuItmHelp});
            // 
            // mnuItmRun
            // 
            this.mnuItmRun.Index = 0;
            this.mnuItmRun.Text = "运行窗体(&R)";
            // 
            // mnuItemWindow
            // 
            this.mnuItemWindow.Index = 1;
            this.mnuItemWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItmCascade,
            this.mnuItmTileHorizontal,
            this.mnuItmTileVertical,
            this.menuItem1});
            this.mnuItemWindow.Text = "窗口(&W)";
            // 
            // mnuItmCascade
            // 
            this.mnuItmCascade.Index = 0;
            this.mnuItmCascade.Text = "层叠窗口";
            this.mnuItmCascade.Click += new System.EventHandler(this.mnuItmCascade_Click);
            // 
            // mnuItmTileHorizontal
            // 
            this.mnuItmTileHorizontal.Index = 1;
            this.mnuItmTileHorizontal.Text = "横向平铺窗口";
            this.mnuItmTileHorizontal.Click += new System.EventHandler(this.mnuItmTileHorizontal_Click);
            // 
            // mnuItmTileVertical
            // 
            this.mnuItmTileVertical.Index = 2;
            this.mnuItmTileVertical.Text = "纵向平铺窗口";
            this.mnuItmTileVertical.Click += new System.EventHandler(this.mnuItmTileVertical_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";
            // 
            // mnuItmHelp
            // 
            this.mnuItmHelp.Index = 2;
            this.mnuItmHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItmAbout});
            this.mnuItmHelp.Text = "帮助(&H)";
            // 
            // mnuItmAbout
            // 
            this.mnuItmAbout.Index = 0;
            this.mnuItmAbout.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.mnuItmAbout.Text = "关于(&A)";
            this.mnuItmAbout.Click += new System.EventHandler(this.mnuItmAbout_Click);
            // 
            // staBarMain
            // 
            this.staBarMain.Location = new System.Drawing.Point(0, 343);
            this.staBarMain.Name = "staBarMain";
            this.staBarMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.pnlInfo,
            this.pnlNum});
            this.staBarMain.ShowPanels = true;
            this.staBarMain.Size = new System.Drawing.Size(584, 22);
            this.staBarMain.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Width = 300;
            // 
            // pnlNum
            // 
            this.pnlNum.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.pnlNum.Name = "pnlNum";
            this.pnlNum.Width = 267;
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(584, 365);
            this.Controls.Add(this.staBarMain);
            this.IsMdiContainer = true;
            this.Menu = this.mnuMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "动态加载 DLL 窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNum)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void FrmMain_Load(object sender, System.EventArgs e)
		{
			Assembly assembly = null;
			string windowsPath = Path.Combine(Application.StartupPath, "Windows");

			foreach (string dllFile in Directory.GetFiles(windowsPath, "*.dll"))
			{
				assembly = Assembly.LoadFile(dllFile);
				Type[] types = assembly.GetTypes();
				
				foreach (Type t in types)
				{
					if (t.BaseType == typeof(Form))
					{
						this.formTypes.Add(t);
						MenuItem item = this.mnuItmRun.MenuItems.Add(t.FullName);
						item.Click += new EventHandler(menuItemNewItem_Click);
					}
				}
			}
		}

		private void menuItemNewItem_Click(object sender, EventArgs e)
		{
			MenuItem item = (MenuItem)sender;

			Type t = (Type)(this.formTypes[item.Index]);

			Object obj = Activator.CreateInstance(t);
			this.formObjects.Add(obj);
			formNum += 1;

			t.InvokeMember("MdiParent", BindingFlags.SetProperty, null, obj, new object[] {this});
			t.InvokeMember("Text", BindingFlags.SetProperty, null, obj, new object[] {t.FullName+"  窗体："+formNum});
			t.InvokeMember ("Show", BindingFlags.InvokeMethod, null, obj, new object [] {});

			((Form)obj).Closing += new CancelEventHandler(FrmWindow_Closing);
			((Form)obj).Activated += new EventHandler(FrmWindow_Activated);
			MenuItem menuItem = this.mnuItemWindow.MenuItems.Add(((Form)obj).Text);
			menuItem.Click += new EventHandler(menuItemWindow_Click);

			this.pnlNum.Text = "当前装载了"+this.formObjects.Count+"个窗体";
			this.pnlInfo.Text = "当前活动窗体："+this.ActiveMdiChild.Text;
		}

		private void menuItemWindow_Click(object sender, System.EventArgs e)
		{
			MenuItem item = (MenuItem)sender;

			((Form)(this.formObjects[item.Index-4])).Activate();

			this.pnlNum.Text = "当前装载了"+this.formObjects.Count+"个窗体";
			this.pnlInfo.Text = "当前活动窗体："+this.ActiveMdiChild.Text;
		}

		private void FrmWindow_Activated(object sender, System.EventArgs e)
		{
			this.pnlNum.Text = "当前装载了"+this.formObjects.Count+"个窗体";
			this.pnlInfo.Text = "当前活动窗体："+this.ActiveMdiChild.Text;
		}

		private void FrmWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for (int i=0; i<this.formObjects.Count; i++)
			{
				if (((Form)this.formObjects[i]).Text == ((Form)sender).Text)
				{
					this.formObjects.RemoveAt(i);
					this.mnuItemWindow.MenuItems.RemoveAt(i+4);

					this.pnlNum.Text = "当前装载了"+this.formObjects.Count+"个窗体";
					this.pnlInfo.Text = "当前活动窗体："+this.ActiveMdiChild.Text;
					break;
				}
			}
		}

		private void mnuItmCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mnuItmTileHorizontal_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void mnuItmTileVertical_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnuItmAbout_Click(object sender, System.EventArgs e)
		{
			new FrmAbout().ShowDialog(this);
		}
	}
}
