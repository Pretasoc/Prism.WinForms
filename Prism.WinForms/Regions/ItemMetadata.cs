

using System;
using System.Windows;

namespace Prism.Regions
{
    /// <summary>
    /// Defines a class that wraps an item and adds metadata for it.
    /// </summary>
    public class ItemMetadata
    {

        private bool isActive;

        /// <summary>
        /// Initializes a new instance of <see cref="ItemMetadata"/>.
        /// </summary>
        /// <param name="item">The item to wrap.</param>
        public ItemMetadata(object item)
        {
            // check for null
            this.Item = item;
        }

        /// <summary>
        /// Gets the wrapped item.
        /// </summary>
        /// <value>The wrapped item.</value>
        public object Item { get; private set; }

        /// <summary>
        /// Gets or sets a name for the wrapped item.
        /// </summary>
        /// <value>The name of the wrapped item.</value>
        public string Name
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the wrapped item is considered active.
        /// </summary>
        /// <value><see langword="true" /> if the item should be considered active; otherwise <see langword="false" />.</value>
        public bool IsActive
        {
            get {
                return isActive;
            }
            set
            {
                if(isActive != value)
                {
                    isActive = value;
                    InvokeMetadataChanged();
                }
            }
        }

        /// <summary>
        /// Occurs when metadata on the item changes.
        /// </summary>
        public event EventHandler MetadataChanged;

        /// <summary>
        /// Explicitly invokes <see cref="MetadataChanged"/> to notify listeners.
        /// </summary>
        public void InvokeMetadataChanged()
        {
            MetadataChanged?.Invoke(this, EventArgs.Empty);
        }

   
    }
}