using System;

namespace System.Collections
{
    /// <summary>
    /// An IDictionary is a possibly unordered set of key-value pairs.
    /// Keys can be any non-null object.  Values can be any object.
    /// You can look up a value in an IDictionary via the default indexed
    /// property, Items.
    /// </summary>
    public interface IDictionary : ICollection
    {
        /// <summary>
        /// The Item property provides methods to read and edit entries
        /// in the Dictionary.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Object this[Object key]
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a collections of the keys in this dictionary.
        /// </summary>
        ICollection Keys
        {
            get;
        }

        /// <summary>
        /// Returns a collections of the values in this dictionary.
        /// </summary>
        ICollection Values
        {
            get;
        }

        /// <summary>
        /// Returns whether this dictionary contains a particular key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Contains(Object key);

        /// <summary>
        /// Adds a key-value pair to the dictionary.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(Object key, Object value);

        /// <summary>
        /// Removes all pairs from the dictionary.
        /// </summary>
        void Clear();

        /// <summary>
        /// An IDictionary implementation can indicate it can not change
        /// Key-Value pairs
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// An IDictionary implementation can indicate it can not change
        /// The capacity of the Key-Value storage
        /// </summary>
        bool IsFixedSize { get; }

        // Returns an IDictionaryEnumerator for this dictionary.
        //new IDictionaryEnumerator GetEnumerator();

        /// <summary>
        /// Removes a particular key from the dictionary.
        /// </summary>
        /// <param name="key"></param>
        void Remove(Object key);
    }
}