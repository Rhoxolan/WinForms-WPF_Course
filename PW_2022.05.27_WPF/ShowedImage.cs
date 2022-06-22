using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;

namespace PW_2022._05._27_WPF
{
    public class ShowedImage : INotifyPropertyChanged
    {
        private string path;
        private FileInfo fileinfo;

        public string Path
        {
            get { return path; }
            set
            {
                path = value;
                OnPropertyChanged("Path");
            }
        }

        public FileInfo Fileinfo
        {
            get { return fileinfo; }
            set
            {
                fileinfo = value;
                OnPropertyChanged("Fileinfo");
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
