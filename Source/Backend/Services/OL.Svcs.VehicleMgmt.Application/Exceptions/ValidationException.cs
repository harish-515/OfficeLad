// <copyright file="ValidationException.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Security.Permissions;
    using FluentValidation.Results;

    /// <summary>
    /// Validation exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public sealed class ValidationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        public ValidationException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="failures">List of failures.</param>
        public ValidationException(List<ValidationFailure> failures)
            : this()
        {
            this.Failures = new Dictionary<string, string[]>();
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                this.Failures.Add(propertyName, propertyFailures);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public ValidationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // The Serializer invokes this constructor through reflection, so it can be private.
        private ValidationException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            this.Failures = (IDictionary<string, string[]>)serializationInfo.GetValue(
                "ValidationFailures", typeof(IDictionary<string, string[]>));
        }

        /// <summary>
        /// Gets the list of failures.
        /// </summary>
        /// <value>
        /// The failures.
        /// </value>
        public IDictionary<string, string[]> Failures { get; }

        /// <inheritdoc />
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue(
                "ValidationFailures",
                this.Failures,
                typeof(IDictionary<string, string[]>));

            // Must call through to the base class to let it save its own state
            base.GetObjectData(info, context);
        }
    }
}
