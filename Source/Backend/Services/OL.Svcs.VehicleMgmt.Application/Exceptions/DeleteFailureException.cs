// <copyright file="DeleteFailureException.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Delete failure exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public sealed class DeleteFailureException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFailureException"/> class.
        /// </summary>
        /// <param name="name">Name of entity.</param>
        /// <param name="key">Key of the entity.</param>
        /// <param name="message">Exception message.</param>
        public DeleteFailureException(string name, object key, string message)
            : base($"Deletion of entity \"{name}\" ({key}) failed. {message}")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFailureException"/> class.
        /// </summary>
        public DeleteFailureException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFailureException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public DeleteFailureException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFailureException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public DeleteFailureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // The Serializer invokes this constructor through reflection, so it can be private.
        private DeleteFailureException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
