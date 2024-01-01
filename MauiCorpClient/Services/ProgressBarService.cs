namespace MauiCorpClient.Services
{
    public class ProgressBarService
    {
        public event Action OnVisibilityChanged;

        private bool _visible;
        public bool Visible
        {
            get => _visible;
            set
            {
                if (_visible != value)
                {
                    _visible = value;
                    NotifyVisibilityChanged();
                }
            }
        }

        private void NotifyVisibilityChanged() => OnVisibilityChanged?.Invoke();
    }
}
