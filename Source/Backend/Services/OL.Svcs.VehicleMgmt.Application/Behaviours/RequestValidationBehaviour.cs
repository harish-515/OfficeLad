// <copyright file="RequestValidationBehaviour.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Behaviours
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentValidation;
    using MediatR;

    /// <summary>
    /// Request validation behavior class.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <seealso cref="MediatR.IPipelineBehavior{TRequest, TResponse}" />
    public class RequestValidationBehaviour<TRequest, TResponse>
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RequestValidationBehaviour{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="validators">The validators.</param>
        public RequestValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }

        /// <inheritdoc />
        public Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext(request);

            var failures = this.validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();

            if (failures.Count != 0)
            {
                throw new ValidationException(failures);
            }

            return next?.Invoke();
        }
    }
}
