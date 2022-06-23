using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Win32;
using System.Windows.Input;

namespace PW_2022._05._27_WPF_V2
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        public BindingList<ShowedImage> Images { get; set; }

        private ShowedImage imageShowed;
        private RelayCommand addCommand;
        private RelayCommand removeCommand;

        public ApplicationViewModel()
        {
            Images = new BindingList<ShowedImage>();
            imageShowed = null;
            addCommand = null;
            removeCommand = null;
        }

        //Добавление изображения
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

        //Удаление изображения
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
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
