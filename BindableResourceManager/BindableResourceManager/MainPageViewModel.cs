using BindableResourceManager.Support;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindableResourceManager
{
    class MainPageViewModel
    {
        public ICommand JapaneseCommand { get; }
        public ICommand EnglishCommand { get; }

        public MainPageViewModel()
        {
            JapaneseCommand = new Command(() => ResourceService.Instance.ChangeCulture("ja-JP"));
            EnglishCommand = new Command(() => ResourceService.Instance.ChangeCulture("en-US"));
        }
    }
}
