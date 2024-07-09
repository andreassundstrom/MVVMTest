using System.Windows.Input;

namespace MVVMDemo.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action<Object> _Execute { get; set; }
        public Predicate<Object> _Predicate { get; set; }

        public RelayCommand(Action<object> ExecuteMethod, Predicate<object> CanExecuteMethod)
        {
            _Execute = ExecuteMethod;
            _Predicate = CanExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _Predicate.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute.Invoke(parameter);
        }
    }
}
