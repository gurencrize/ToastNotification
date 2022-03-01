using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Threading;

string text = string.Join(Environment.NewLine, args);
var toast = new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("Notification")
    .AddText(text)
    .AddButton(new ToastButton()
        .SetContent("OK")
        .AddArgument("action", "ok"));
toast.Show();
Thread.Sleep(30000);
