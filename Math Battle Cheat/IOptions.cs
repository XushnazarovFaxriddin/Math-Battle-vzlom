using OpenQA.Selenium;

namespace Math_Battle_Cheat
{
    public interface IOptions
    {
        ICookieJar Cookies { get; }
        IWindow Window { get; }
        ILogs Logs { get; }
        INetwork Network { get; }

        ITimeouts Timeouts();
    }
}