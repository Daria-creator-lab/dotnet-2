﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using TaskClientWPF.Commands;
using System.Threading.Tasks;
using TaskClientWPF.Views;
using Lab2TaskClient;

namespace TaskClientWPF.ViewModels
{
    public class TasksViewModel: INotifyPropertyChanged
    {
        private TaskRepositoryClient _taskRepository;
        public ObservableCollection<TaskViewModel> Tasks { get; } = new ObservableCollection<TaskViewModel>();

        private TaskViewModel _selectedTask;
        public TaskViewModel SelectedTask
        {
            get => _selectedTask;
            set
            {
                if (value == _selectedTask) return;
                _selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }
        public Command ShowTaskCommand { get; private set; }

        public async System.Threading.Tasks.Task InitializeAsync(TaskRepositoryClient taskRepository)
        {
            _taskRepository = taskRepository;

            var tasks = await _taskRepository.GetTasksAsync();
            foreach(var task in tasks)
            {
                var taskViewModel = new TaskViewModel();
                await taskViewModel.InitializeAsync(taskRepository, task.TaskId);
                Tasks.Add(taskViewModel);
            }
            ShowTaskCommand = new Command(commandParameter =>
            {
                var taskInfoView = new TaskView(SelectedTask);
                taskInfoView.ShowDialog();
            }, null);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
