namespace Wamby.Client.Interfaces
{
    public interface IProgressMessage
    {
        IProgressMessage SetMessage(string message);
        IProgressMessage ClearMessage();
        IProgressMessage SetMessageLastScan(string message);
        IProgressMessage ClearMessageLastScan();
        IProgressMessage SetProgress(int value);
        IProgressMessage ClearProgress();
    }
}
