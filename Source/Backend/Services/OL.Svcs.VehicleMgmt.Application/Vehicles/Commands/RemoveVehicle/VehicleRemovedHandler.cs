// <copyright file="VehicleRemovedHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RemoveVehicle
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Vehicle removed handler.
    /// </summary>
    /// <seealso cref="NotificationHandler{VehicleRemoved}" />
    public class VehicleRemovedHandler : INotificationHandler<VehicleRemoved>
    {
        private readonly INotificationService notificationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRemovedHandler"/> class.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public VehicleRemovedHandler(INotificationService notification)
        {
            this.notificationService = notification;
        }

        /// <inheritdoc />
        public async Task Handle(
            VehicleRemoved notification,
            CancellationToken cancellationToken)
        {
            await this.notificationService.SendAsync().ConfigureAwait(false);
        }
    }
}
