// <copyright file="RemoveVehicleCommandValidationsCollection.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RemoveVehicle
{
    using FluentValidation;

    /// <summary>
    /// Remove vehicle command validations collection.
    /// </summary>
    /// <seealso cref="AbstractValidator{RemoveVehicleCommand}" />
    public class RemoveVehicleCommandValidationsCollection
        : AbstractValidator<RemoveVehicleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RemoveVehicleCommandValidationsCollection"/> class.
        /// </summary>
        public RemoveVehicleCommandValidationsCollection()
        {
            this.RuleFor(x => x.Id).NotEmpty();
        }
    }
}
