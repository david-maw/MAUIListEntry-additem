using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MAUIListEntry
{
    internal class ViewModel
    {
        public ObservableCollection<string> StringList { get; set; } = new () { "String 1","String2" };
        public ViewModel()
        {
            TestCommand = new AsyncRelayCommand(TestFunction);
        }
        public ICommand TestCommand { get; }

        private async Task TestFunction()
        {
            StringList.Remove(StringList.Last());
            await Task.Delay(300);
            StringList.Add("added");
        }
    }
}
