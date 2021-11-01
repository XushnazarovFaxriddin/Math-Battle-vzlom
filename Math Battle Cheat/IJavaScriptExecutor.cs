namespace Math_Battle_Cheat
{
    internal interface IJavaScriptExecutor
    {
        object ExecuteAsyncScript(string script, params object[] args);
        object ExecuteScript(PinnedScript script, params object[] args);
        object ExecuteScript(string script, params object[] args);
    }
}