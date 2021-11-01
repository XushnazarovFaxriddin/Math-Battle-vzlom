using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Math_Battle_Cheat
{
    public interface IWebDriver
    {
        string Url { get; set; }
        string Title { get; }
        string PageSource { get; }
        string CurrentWindowHandle { get; }
        ReadOnlyCollection<string> WindowHandles { get; }

        void Close();
        IOptions Manage();
        INavigation Navigate();
        void Quit();
        ITargetLocator SwitchTo();
    }
}