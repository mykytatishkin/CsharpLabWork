using System;
using System.ComponentModel;

namespace WindowsFormsDiary.Model
{
    [Serializable]
    public class DiaryItem : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string _Name;
        public string Name 
        {
            get { return _Name; }
            set 
            {
                if (_Name != value)
                {
                    _Name = value;

                    OnPropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public DateTime Created { get; set; }
        public DateTime ToDo { get; set; }

        public string FullName 
        {
            get { return $"{Name} {Created:dd-MM-yyyy HH:mm}"; }
        }

        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
