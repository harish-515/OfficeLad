// <copyright file="VehicleUpdatedHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.UpdateVehicle
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Vehicle registered handler.
    /// </summary>
    /// <seealso cref="NotificationHandler{VehicleUpdated}" />
    public class VehicleUpdatedHandler : INotificationHandler<VehicleUpdated>
    {
        private readonly INotificationService notificationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleUpdatedHandler"/> class.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public VehicleUpdatedHandler(INotificationService notification)
        {
            this.notificationService = notification;
        }

        /// <inheritdoc />
        public async Task Handle(
            VehicleUpdated notification,
            CancellationToken cancellationToken)
        {
            await this.notificationService.SendAsync().ConfigureAwait(false);
        }
    }
}
