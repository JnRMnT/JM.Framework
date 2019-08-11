using System;
using System.Collections.Generic;
using System.Text;

namespace JM.Entities.Interfaces
{
    /// <summary>
    /// Interface to be used for Factory Pattern Object Creation
    /// </summary>
    /// <typeparam name="T">The base class type of the product that will be built in the factory</typeparam>
    /// <typeparam name="X">Type of the 'product type' identifier that will be passed to build method of the Factory</typeparam>
    public interface IFactory<T, X>
    {
        /// <summary>
        /// Build process of the factory. Based on the type of the product, factory builds the instance.
        /// </summary>
        /// <param name="type">Product type</param>
        /// <returns>Instance of the required product type</returns>
        T Build(X type);
    }
}
