// <copyright file="IMapFrom.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Mappings
{
    using AutoMapper;

    /// <summary>
    /// Map from interface.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface IMapFrom<T>
    {
        /// <summary>
        /// Mapping the specified profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        void Mapping(Profile profile)
        {
            if (profile != null)
            {
                _ = profile.CreateMap(typeof(T), this.GetType());
            }
        }
    }
}
