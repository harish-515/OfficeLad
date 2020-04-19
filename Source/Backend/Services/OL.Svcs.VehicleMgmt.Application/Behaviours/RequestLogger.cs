// <copyright file="RequestLogger.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Behaviours
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR.Pipeline;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Request logger behaviour.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <seealso cref="MediatR.Pipeline.IRequestPreProcessor{TRequest}" />
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogger{TRequest}"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public RequestLogger(ILogger<TRequest> logger)
        {
            this.logger = logger;
        }

        /// <inheritdoc />
        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var name = typeof(TRequest).Name;

            this.logger.LogInformation(
                "Vehicle Management Request: {Name} {@Request}",
                name,
                request);

            return Task.CompletedTask;
        }
    }
}
