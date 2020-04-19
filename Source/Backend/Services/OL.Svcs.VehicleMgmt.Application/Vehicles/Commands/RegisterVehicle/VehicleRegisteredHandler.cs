// <copyright file="VehicleRegisteredHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Vehicle registered handler.
    /// </summary>
    /// <seealso cref="NotificationHandler{VehicleRegistered}" />
    public class VehicleRegisteredHandler : INotificationHandler<VehicleRegistered>
    {
        private readonly INotificationService notificationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRegisteredHandler"/> class.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public VehicleRegisteredHandler(INotificationService notification)
        {
            this.notificationService = notification;
        }

        /// <inheritdoc />
        public async Task Handle(
            VehicleRegistered notification,
            CancellationToken cancellationToken)
        {
            await this.notificationService.SendAsync().ConfigureAwait(false);
        }
    }
}
