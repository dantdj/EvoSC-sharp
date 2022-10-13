﻿using EvoSC.Common.Remote;
using Microsoft.Extensions.DependencyInjection;

namespace EvoSC.Common.Interfaces.Controllers;

public interface IControllerContext
{
    /// <summary>
    /// The service scope used to create this context.
    /// </summary>
    public IServiceScope ServiceScope { get; }
    /// <summary>
    /// Pointer to the GBXRemote XMLRPC server client.
    /// </summary>
    public IServerClient Server { get; }

    /// <summary>
    /// Set the service scope for this context.
    /// </summary>
    /// <param name="scope"></param>
    public void SetScope(IServiceScope scope);
}
