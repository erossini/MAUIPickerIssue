using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PickerError
{
	public partial class MainPageViewModel : ObservableObject

	{
		public MainPageViewModel()
		{
			LanguageNative = "Spanish";
		}

		public List<string> SupportedLanguages { get; } = new List<string>() { "English", "French", "German", "Italian", "Spanish" };

        [ObservableProperty] private string _languageNative;
    }
}

