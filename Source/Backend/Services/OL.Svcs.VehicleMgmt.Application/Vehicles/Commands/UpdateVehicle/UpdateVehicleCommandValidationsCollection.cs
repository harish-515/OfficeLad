// <copyright file="UpdateVehicleCommandValidationsCollection.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.UpdateVehicle
{
    using FluentValidation;

    /// <summary>
    /// Update vehicle command validations collection.
    /// </summary>
    /// <seealso cref="AbstractValidator{RemoveVehicleCommand}" />
    public class UpdateVehicleCommandValidationsCollection
        : AbstractValidator<UpdateVehicleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UpdateVehicleCommandValidationsCollection"/> class.
        /// </summary>
        public UpdateVehicleCommandValidationsCollection()
        {
            this.RuleFor(x => x.Id).NotEmpty();
            this.RuleFor(x => x.LicenseNumber).Length(10).NotEmpty();
            this.RuleFor(x => x.Type).MaximumLength(10).NotEmpty();
            this.RuleFor(x => x.Brand).MaximumLength(10).NotEmpty();
        }
    }
}
