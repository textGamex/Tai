﻿using Core.Models.Config;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class SettingPageModel : UINotifyPropertyChanged
    {
        private object data;
        public object Data { get { return data; } set { data = value; OnPropertyChanged(); } }

        private ObservableCollection<string> TabbarData_;
        /// <summary>
        /// tabbar data
        /// </summary>
        public ObservableCollection<string> TabbarData { get { return TabbarData_; } set { TabbarData_ = value; OnPropertyChanged(); } }

        private int TabbarSelectedIndex_;
        /// <summary>
        /// tabbar selected item index
        /// </summary>
        public int TabbarSelectedIndex { get { return TabbarSelectedIndex_; } set { TabbarSelectedIndex_ = value; OnPropertyChanged(); } }

        private string version;
        /// <summary>
        /// 软件版本号
        /// </summary>
        public string Version{ get { return version; } set { version = value; OnPropertyChanged(); } }

    }
}