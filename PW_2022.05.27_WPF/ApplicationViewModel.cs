﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Win32;

namespace PW_2022._05._27_WPF
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private ShowedImage imageShowed;

        public ObservableCollection<ShowedImage> Images { get; set; }

        public ApplicationViewModel()
        {
            Images = new ObservableCollection<ShowedImage>();
        }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      OpenFileDialog ofd = new OpenFileDialog();
                      if ((bool)ofd.ShowDialog())
                      {
                          Images.Add(new ShowedImage { Path = ofd.FileName, Fileinfo = new FileInfo(ofd.FileName) });
                      }
                  }));
            }
        }

        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      ShowedImage image = obj as ShowedImage;
                      if (image != null)
                      {
                          Images.Remove(image);
                      }
                  },
                 (obj) => Images.Count > 0));
            }
        }

        public ShowedImage ImageShowed
        {
            get { return imageShowed; }
            set
            {
                imageShowed = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
