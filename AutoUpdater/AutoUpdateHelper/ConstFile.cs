/*****************************************************************
 * Copyright (C) Knights Warrior Corporation. All rights reserved.
 * 
 * Author:   圣殿骑士（Knights Warrior） 
 * Email:    KnightsWarrior@msn.com
 * Website:  http://www.cnblogs.com/KnightsWarrior/       http://knightswarrior.blog.51cto.com/
 * Create Date:  5/8/2010 
 * Usage:
 *
 * RevisionHistory
 * Date         Author               Description
 * 
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightsWarriorAutoupdater
{
    public class ConstFile
    {
        public const string TEMPFOLDERNAME = "TempFolderBak";
        public const string CONFIGFILEKEY = "config_";
        public const string CONFIGFILE = "config";
        public const string FILENAME = "AutoUpdater.config";
        public const string ROOLBACKFILE = "WEBSiteUpdate.exe";
        public const string MESSAGETITLE = "自动更新";
        public const string CANCELORNOT = "更新正在进行是否取消";
        public const string APPLYTHEUPDATE = "程序需要进行重启，请按ok充实";
        public const string NOTNETWORK = "更新失败请重试";
    }
}
