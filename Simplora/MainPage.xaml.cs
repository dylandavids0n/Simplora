namespace Simplora;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSearchClicked(object sender, EventArgs e)
	{
		WebWindow.Source = UrlEntry.Text;
	}

	private void OnBackClicked(object sender, EventArgs e)
	{
		//do nothing for now.
	}

	private void OnForwardClicked(object sender, EventArgs e)
	{
		//do nothing for now.
	}

	private void OnRefreshClicked(object sender, EventArgs e)
	{
		WebWindow.Reload();
	}

	private void OnEntryTextChanged(object sender, EventArgs e)
	{
		//do nothing for now.
	}

	private void OnEntryCompleted(object sender, EventArgs e)
	{
		WebWindow.Source = UrlEntry.Text;
	}
}

