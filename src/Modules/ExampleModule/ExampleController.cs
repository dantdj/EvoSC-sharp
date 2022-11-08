﻿using EvoSC.Common.Controllers;
using EvoSC.Common.Controllers.Attributes;
using EvoSC.Common.Controllers.Context;
using EvoSC.Common.Events;
using EvoSC.Common.Events.Attributes;
using EvoSC.Common.Interfaces;
using EvoSC.Common.Interfaces.Controllers;
using EvoSC.Common.Remote;
using EvoSC.Common.Util;
using GbxRemoteNet.Events;
using Microsoft.Extensions.Logging;

namespace EvoSC.Modules.Official.ExampleModule;

[Controller]
public class ExampleController : EvoScController<IControllerContext>
{
    private readonly IMySettings _settings;
    
    public ExampleController(IMySettings settings)
    {
        _settings = settings;
    }

    [Subscribe(GbxRemoteEvent.PlayerChat)]
    public Task OnChat(object sender, PlayerChatEventArgs args)
    {
        Console.WriteLine("option: " + _settings.MyOption);
        
        return Task.CompletedTask;
    }
}
