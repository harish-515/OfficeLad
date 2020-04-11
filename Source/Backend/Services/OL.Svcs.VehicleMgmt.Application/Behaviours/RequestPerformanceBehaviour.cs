// <copyright file="RequestPerformanceBehaviour.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Behaviours
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Request performance behaviour.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <seealso cref="MediatR.IPipelineBehavior{TRequest, TResponse}" />
    public class RequestPerformanceBehaviour<TRequest, TResponse>
        : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly Stopwatch timer;
        private readonly ILogger<TRequest> logger;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RequestPerformanceBehaviour{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="logger">Logger object.</param>
        public RequestPerformanceBehaviour(
            ILogger<TRequest> logger)
        {
            this.timer = new Stopwatch();
            this.logger = logger;
        }

        /// <inheritdoc />
        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            this.timer.Start();

            var response = await next().ConfigureAwait(false);

            this.timer.Stop();

            if (this.timer.ElapsedMilliseconds > 1000)
            {
                var name = typeof(TRequest).Name;

                this.logger.LogWarning(
                    "Vehicle Management Long Running Request:"
                     + "{Name} ({ElapsedMilliseconds} milliseconds) {@Request}",
                    name,
                    this.timer.ElapsedMilliseconds,
                    request);
            }

            return response;
        }
    }
}
