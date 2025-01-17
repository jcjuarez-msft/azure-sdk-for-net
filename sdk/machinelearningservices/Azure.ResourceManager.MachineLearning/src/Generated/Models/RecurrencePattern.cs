// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Recurrence schedule pattern definition. </summary>
    public partial class RecurrencePattern
    {
        /// <summary> Initializes a new instance of RecurrencePattern. </summary>
        /// <param name="hours"> [Required] List of hours for recurrence schedule pattern. </param>
        /// <param name="minutes"> [Required] List of minutes for recurrence schedule pattern. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hours"/> or <paramref name="minutes"/> is null. </exception>
        public RecurrencePattern(IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            if (hours == null)
            {
                throw new ArgumentNullException(nameof(hours));
            }
            if (minutes == null)
            {
                throw new ArgumentNullException(nameof(minutes));
            }

            Hours = hours.ToList();
            Minutes = minutes.ToList();
            Weekdays = new ChangeTrackingList<Weekday>();
        }

        /// <summary> Initializes a new instance of RecurrencePattern. </summary>
        /// <param name="hours"> [Required] List of hours for recurrence schedule pattern. </param>
        /// <param name="minutes"> [Required] List of minutes for recurrence schedule pattern. </param>
        /// <param name="weekdays"> List of weekdays for recurrence schedule pattern. </param>
        internal RecurrencePattern(IList<int> hours, IList<int> minutes, IList<Weekday> weekdays)
        {
            Hours = hours;
            Minutes = minutes;
            Weekdays = weekdays;
        }

        /// <summary> [Required] List of hours for recurrence schedule pattern. </summary>
        public IList<int> Hours { get; }
        /// <summary> [Required] List of minutes for recurrence schedule pattern. </summary>
        public IList<int> Minutes { get; }
        /// <summary> List of weekdays for recurrence schedule pattern. </summary>
        public IList<Weekday> Weekdays { get; set; }
    }
}
