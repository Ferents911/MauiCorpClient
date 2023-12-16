using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCorpClient.Services
{
    public class NavigationService
    {
        public string[] _activeContext { get; private set; } = { "selected", "", "", "", "" };

        public string[] ActiveContext
        {
            get => _activeContext;
            private set
            {
                if (!value.SequenceEqual(_activeContext))
                {
                    _activeContext = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action OnStateChange;

        private void NotifyStateChanged() => OnStateChange?.Invoke();

        public void SetActiveContext(int itemIndex)
        {
            var newActiveContext = Enumerable.Range(0, _activeContext.Length)
                .Select(i => i == itemIndex ? "selected" : "")
                .ToArray();

            ActiveContext = newActiveContext;
        }
    }
}
