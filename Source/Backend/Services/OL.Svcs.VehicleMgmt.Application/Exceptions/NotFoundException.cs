// <copyright file="NotFoundException.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Not found exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public sealed class NotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="name">Name of the entity.</param>
        /// <param name="key">Key of the entity.</param>
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        public NotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public NotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // The Serializer invokes this constructor through reflection, so it can be private.
        private NotFoundException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}