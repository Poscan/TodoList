using Xamarin.Forms;

namespace ToDoList.Model
{
    class Task : BindableObject
    {
        private bool _isComplete;
        private string _name;

        public Task(string name)
        {
            Name = name;
            IsComplete = false;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;

                _name = value;
                OnPropertyChanged();
            }
        }

        public bool IsComplete
        {
            get => _isComplete;
            set
            {
                if (_isComplete == value) return;

                _isComplete = value;
                OnPropertyChanged();
            }
        }
    }
}
