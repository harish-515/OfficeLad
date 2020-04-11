// <copyright file="BadRequestException.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Bad request exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public sealed class BadRequestException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public BadRequestException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        public BadRequestException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public BadRequestException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // The Serializer invokes this constructor through reflection, so it can be private.
        private BadRequestException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
