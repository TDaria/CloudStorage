﻿namespace CloudStorage.Domain.FileAggregate
{
    using System;

    /// <summary>
    /// Represents a domain model of file.
    /// </summary>
    public class File
    {
        private string _name;

        /// <summary>
        /// Gets or sets the identifier of game.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating where name of file.
        /// </summary>
        /// <value>Name of file.</value>
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (!FileValidation.IsValidName(value))
                {
                    throw new ArgumentException("Wrong name of file");
                }

                this._name = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating where date of creation.
        /// </summary>
        /// <value>Creation date.</value>
        public DateTime CreationDate { get; set; }
    }
}
