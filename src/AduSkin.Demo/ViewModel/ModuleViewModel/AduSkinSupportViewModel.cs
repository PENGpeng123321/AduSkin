﻿using AduSkin.Demo.Data.Enum;
using AduSkin.Demo.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduSkin.Demo.ViewModel
{
   public class AduSkinSupportViewModel : ViewModelBase
   {
      public AduSkinSupportViewModel()
      {
         AllSupports.Add(new SupportUser("不愿意透露名字的网友", "QQ870856195", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=870856195&spec=100","",new string[] { SupportType.Money.ToString()+"：100元" }));
         AllSupports.Add(new SupportUser("沙漠尽头的狼 dotnet9.com", "QQ632871194", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=632871194&spec=100", "", new string[] { SupportType.Extension.ToString() }));
         AllSupports.Add(new SupportUser("关关", "QQ2453966523", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=2453966523&spec=100", "", new string[] { SupportType.Skill.ToString() }));
         AllSupports.Add(new SupportUser("Tom", "QQ17379620", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=17379620&spec=100", "", new string[] { SupportType.Skill.ToString() }));
      }
      private ObservableCollection<SupportUser> _AllSupports =new ObservableCollection<SupportUser>();
      /// <summary>
      /// 赞助人
      /// </summary>
      public ObservableCollection<SupportUser> AllSupports
      {
         get { return _AllSupports; }
         set { Set(ref _AllSupports, value); }
      }
   }
}
