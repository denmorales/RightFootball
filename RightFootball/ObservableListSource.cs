// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObservableListSource.cs" company="">
//   
// </copyright>
// <summary>
//   The observable list source.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RightFootball
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Data.Entity;

    /// <summary>
    /// The observable list source.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : class
    {
        /// <summary>
        /// The _binding list.
        /// </summary>
        private IBindingList bindingList;

        /// <summary>
        /// Gets a value indicating whether contains list collection.
        /// </summary>
        bool IListSource.ContainsListCollection => false;

        /// <summary>
        /// The get list.
        /// </summary>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        IList IListSource.GetList()
        {
            return this.bindingList ?? (this.bindingList = this.ToBindingList());
        }
    }
}