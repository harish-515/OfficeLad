// <copyright file="BaseController.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Api.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Base controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public abstract class BaseController : ControllerBase
    {
        private IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        protected BaseController()
        {
        }

        /// <summary>
        /// Gets mediator.
        /// </summary>
        protected IMediator Mediator => this.mediator ??= this.HttpContext.
            RequestServices.GetService<IMediator>();

        /// <summary>
        /// Models the state error response error.
        /// </summary>
        /// <returns>Action result.</returns>
        protected ActionResult ModelStateErrorResponseError()
        {
            return this.BadRequest(new ValidationProblemDetails(this.ModelState));
        }
    }
}
