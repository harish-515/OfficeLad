// <copyright file="RegisterVehicleCommandValidationsCollection.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle
{
    using FluentValidation;

    /// <summary>
    /// Register vehicle command validations collection.
    /// </summary>
    /// <seealso cref="AbstractValidator{RegisterVehicleCommand}" />
    public class RegisterVehicleCommandValidationsCollection
        : AbstractValidator<RegisterVehicleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegisterVehicleCommandValidationsCollection"/> class.
        /// </summary>
        public RegisterVehicleCommandValidationsCollection()
        {
            this.RuleFor(x => x.LicenseNumber).Length(10).NotEmpty();
            this.RuleFor(x => x.Type).MaximumLength(10).NotEmpty();
            this.RuleFor(x => x.Brand).MaximumLength(10).NotEmpty();
        }
    }
}
