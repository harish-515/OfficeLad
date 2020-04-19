// <copyright file="GetVehicleDetailQueryValidatonsCollection.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehicleDetail
{
    using FluentValidation;

    /// <summary>
    /// Get vehicle detail query validations.
    /// </summary>
    /// <seealso cref="AbstractValidator{GetCustomerDetailQuery}" />
    public class GetVehicleDetailQueryValidatonsCollection : AbstractValidator<GetVehicleDetailQuery>
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GetVehicleDetailQueryValidatonsCollection"/> class.
        /// </summary>
        public GetVehicleDetailQueryValidatonsCollection()
        {
            this.RuleFor(v => v.Id).NotEmpty();
        }
    }
}
