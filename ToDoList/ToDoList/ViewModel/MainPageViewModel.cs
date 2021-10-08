using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ToDoList.Model;
using Xamarin.Forms;

namespace ToDoList.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Task> TaskList { get; }

        public MainPageViewModel()
        {
            TaskList = new ObservableCollection<Task>();

            CreateTaskCommand = new Command(CreateTask);
            DeleteTaskCommand = new Command(DeleteTask);
        }

        public ICommand CreateTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CreateTask(object name)
        {
            TaskList.Add(new Task(name.ToString()));

            OnPropertyChanged();
        }

        private void DeleteTask(object taskObj)
        {
            if(taskObj is Task task)
            {
                TaskList.Remove(task);
            }

            OnPropertyChanged();
        }
    }
}
