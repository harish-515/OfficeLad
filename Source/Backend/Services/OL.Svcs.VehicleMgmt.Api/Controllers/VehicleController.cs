// <copyright file="VehicleController.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using OL.Svcs.VehicleMgmt.Api.DTOs;
    using OL.Svcs.VehicleMgmt.Application.Exceptions;
    using OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle;

    /// <summary>
    /// Vehicle Controller.
    /// </summary>
    /// <seealso cref="BaseController" />
    public class VehicleController : BaseController
    {
        /// <summary>
        /// Register a vehicle.
        /// </summary>
        /// <param name="registerVehicle">Register vehicle dto.</param>
        /// <returns>
        /// Action result.
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterVehicleDto registerVehicle)
        {
            if (!this.ModelState.IsValid)
            {
                return this.ModelStateErrorResponseError();
            }

            if (registerVehicle != null)
            {
                try
                {
                    _ = await this.Mediator.Send(
                    new RegisterVehicleCommand(
                        registerVehicle.LicenseNumber,
                        registerVehicle.Brand,
                        registerVehicle.Type,
                        registerVehicle.OwnerId))
                    .ConfigureAwait(false);
                }
                catch (ValidationException ex)
                {
                    this.BadRequest(ex.Failures);
                }
            }
            else
            {
                this.BadRequest("Body cannot be null.");
            }

            return this.NoContent();
        }
    }
}
