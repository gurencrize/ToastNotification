using Microsoft.Toolkit.Uwp.Notifications;
using System;

namespace ToastNotification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var toast = new ToastContentBuilder();
            // toast.AddArgument("action", "viewConversation");
            // toast.AddArgument("conversationId", 9813);
            foreach(string s in args)
            {
                toast.AddText(s);
            }
            toast.Show();
        }
    }
}
