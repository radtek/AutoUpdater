using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KnightsWarriorAutoupdater;
using System.Net;
using System.Xml;
using AutoUpdater;

namespace WebSiteUpdateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            InitCheckUpdate();
        }

        static void InitCheckUpdate()
        {

            #region check and download new version program
            bool bHasError = false;
            IAutoUpdater autoUpdater = new KnightsWarriorAutoupdater.AutoUpdaterConsole();
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
               
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                
            }
            catch (Exception exp)
            {
                bHasError = true;
                
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
    }
}
