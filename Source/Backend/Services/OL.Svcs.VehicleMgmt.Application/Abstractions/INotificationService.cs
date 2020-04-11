// <copyright file="INotificationService.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Abstractions
{
    using System.Threading.Tasks;

    /// <summary>
    /// Notification Service.
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Sends a notification asynchronously.
        /// </summary>
        /// <returns>Task object.</returns>
        Task SendAsync();
    }
}
