using System;

namespace clipboard-history-manager-windows.Hooks
{
    public interface IKeyboardMonitor
    {
        event EventHandler<GlobalKeyboardHookEventArgs> KeyboardEvent;
        void StartMonitor();
        void StopMonitor();
    }
}
