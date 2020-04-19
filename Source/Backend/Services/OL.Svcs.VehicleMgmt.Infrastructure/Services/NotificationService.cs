// <copyright file="NotificationService.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Infrastructure.Services
{
    using System.Threading.Tasks;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Notification Service.
    /// </summary>
    /// <seealso cref="OL.Svcs.VehicleMgmt.Application.Abstractions.INotificationService" />
    public class NotificationService : INotificationService
    {
        /// <inheritdoc />
        public Task SendAsync()
        {
            return Task.CompletedTask;
        }
    }
}
