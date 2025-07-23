using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormTest
{
	/// <summary>
	/// FrmAbout 的摘要说明。
	/// </summary>
	public class FrmAbout : System.Windows.Forms.Form
	{
		//窗体透明度渐变标志
		private bool flag;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel lnkEmail;
		private System.Windows.Forms.LinkLabel lnkWeb;
		private System.Diagnostics.Process processWeb;
		private System.Diagnostics.Process processEmail;
		private System.ComponentModel.IContainer components;

		public FrmAbout()
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
				if(components != null)
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
            this.lnkEmail = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkWeb = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.processWeb = new System.Diagnostics.Process();
            this.processEmail = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // lnkEmail
            // 
            this.lnkEmail.Location = new System.Drawing.Point(200, 96);
            this.lnkEmail.Name = "lnkEmail";
            this.lnkEmail.Size = new System.Drawing.Size(180, 24);
            this.lnkEmail.TabIndex = 4;
            this.lnkEmail.TabStop = true;
            this.lnkEmail.Text = "dbyoung@sina.com";
            this.lnkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmail_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(202, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(152, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(152, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "博 客：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(152, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "M S N：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(152, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Q  Q：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkWeb
            // 
            this.lnkWeb.Location = new System.Drawing.Point(200, 24);
            this.lnkWeb.Name = "lnkWeb";
            this.lnkWeb.Size = new System.Drawing.Size(205, 24);
            this.lnkWeb.TabIndex = 1;
            this.lnkWeb.TabStop = true;
            this.lnkWeb.Text = "https://blog.csdn.net/dbyoung";
            this.lnkWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeb_LinkClicked);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(200, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "dbyoung@sina.com";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(200, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "836866263";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processWeb
            // 
            this.processWeb.StartInfo.Domain = "";
            this.processWeb.StartInfo.FileName = "https://blog.csdn.net/dbyoung";
            this.processWeb.StartInfo.LoadUserProfile = false;
            this.processWeb.StartInfo.Password = null;
            this.processWeb.StartInfo.StandardErrorEncoding = null;
            this.processWeb.StartInfo.StandardOutputEncoding = null;
            this.processWeb.StartInfo.UserName = "";
            this.processWeb.SynchronizingObject = this;
            // 
            // processEmail
            // 
            this.processEmail.StartInfo.Domain = "";
            this.processEmail.StartInfo.FileName = "mailto:dbyoung@sina.com";
            this.processEmail.StartInfo.LoadUserProfile = false;
            this.processEmail.StartInfo.Password = null;
            this.processEmail.StartInfo.StandardErrorEncoding = null;
            this.processEmail.StartInfo.StandardOutputEncoding = null;
            this.processEmail.StartInfo.UserName = "";
            this.processEmail.SynchronizingObject = this;
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(460, 195);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnkWeb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "动态加载 DLL 窗体";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void FrmAbout_Load(object sender, System.EventArgs e)
		{
			this.flag = true;
			this.Opacity = 0;

			this.timer1.Enabled =true;
			this.timer1.Interval = 10;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (flag)
			{
				if (this.Opacity < 1)
				{
					this.Opacity += 0.01;
				}
				else
				{
					this.timer1.Enabled = false;
				}
			}
			else
			{
				this.timer1.Interval = 15;

				if (this.Opacity > 0)
				{
					this.Opacity -= 0.01;
				}
				else
				{
					this.Close();
					this.timer1.Enabled = false;
				}
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			flag = false;
			this.timer1.Enabled = true;
		}

		private void lnkWeb_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.processWeb.Start();
		}

		private void lnkEmail_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.processEmail.Start();
		}
	}
}
