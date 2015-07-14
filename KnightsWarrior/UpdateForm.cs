using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoUpdater;
using System.Net;
using System.Xml;
using KnightsWarriorAutoupdater;

namespace WEBSiteUpdate
{
    public partial class UpdateForm : Form
    {
      
        public UpdateForm()
        {
            InitializeComponent();
            InitCheckUpdate();
        }
        void InitCheckUpdate()
        {
           
            #region check and download new version program
            bool bHasError = false;
            IAutoUpdater autoUpdater = new KnightsWarriorAutoupdater.AutoUpdater();
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                MessageBox.Show("服务器连接失败");
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                MessageBox.Show("下载更新文件错误");
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                MessageBox.Show("升级文件配置错误");
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                MessageBox.Show("下载升级文件错误");
            }
            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("更新过程中出现错误");
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                        //Log the message to your file or database
                    }
                }
                OperProcess op = new OperProcess();
                //启动进程
                op.StartProcess();
              //  this.Close();
            }
            #endregion
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
