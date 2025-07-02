using Microsoft.JSInterop;

public class ThemeService
{
    private readonly IJSRuntime js;
    private bool isDark = false;

    public ThemeService(IJSRuntime js)
    {
        this.js = js;
    }

    public async Task InitializeAsync()
    {
        isDark = await js.InvokeAsync<bool>("getIsDark");
    }

    private async Task ToggleTheme()
    {
        isDark = !isDark;
        await js.InvokeVoidAsync("toggleTheme", isDark);
    }

    public async Task LightToggle()
    {
        if (!isDark) return;
        await ToggleTheme();
    }

    public async Task DarkToggle()
    {
        if (isDark) return;
        await ToggleTheme();
    }
}