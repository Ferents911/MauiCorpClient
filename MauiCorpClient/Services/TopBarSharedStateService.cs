namespace MauiCorpClient.Services
{
    public class TopBarSharedStateService
    {
        public event Action ParametersChanged;

        public bool HasTopPicture { get; private set; } = true;
        public string Icon { get; private set; } = "img/big-logo-copany.png";
        public string Title { get; private set; } = "Привіт, Микола";
        public bool IsCentered { get; private set; } = false;

        public void UpdateParameters(bool hasTopPicture, string icon, string title, bool isCentered)
        {
            HasTopPicture = hasTopPicture;
            Icon = icon;
            Title = title;
            IsCentered = isCentered;

            ParametersChanged?.Invoke();
        }
    }
}
