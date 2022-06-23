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

namespace PW_2022._05._27_WPF_V2
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        public BindingList<ShowedImage> Images { get; set; }

        private ShowedImage imageShowed;

        public ApplicationViewModel()
        {
            Images = new BindingList<ShowedImage>();
            imageShowed = null;
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
