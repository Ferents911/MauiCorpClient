namespace MauiCorpClient.Services
{
    public class AppStateService
    {
        public bool IsPageLoaded { get; set; } = false;

        public void SetPageLoaded(bool loaded)
        {
            IsPageLoaded = loaded;
            NotifyStateChanged();
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
