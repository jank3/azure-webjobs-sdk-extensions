﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Microsoft.Azure.WebJobs
{
    /// <summary>
    /// Attribute used to bind a parameter to a Twilio SMSMessage that will automatically be
    /// sent when the function completes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class TwilioSmsAttribute : Attribute
    {
        /// <summary>
        /// Optional. A string value indicating the app setting to use as the Twilio Account SID, 
        /// if different than the one specified in the <see cref="Extensions.Twilio.TwilioSmsConfiguration"/>.
        /// </summary>
        [AutoResolve(AllowTokens = false)]
        public string AccountSidSetting { get; set; }

        /// <summary>
        /// Optional. A string value indicating the app setting to use as the Twilio Auth Token, 
        /// if different than the one specified in the <see cref="Extensions.Twilio.TwilioSmsConfiguration"/>.
        /// </summary>
        [AutoResolve(AllowTokens = false)]
        public string AuthTokenSetting { get; set; }

        /// <summary>
        /// Gets or sets the message "To" field. May include binding parameters.
        /// </summary>
        [AutoResolve]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the message "From" field. May include binding parameters.
        /// </summary>
        [AutoResolve]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the message "Body" field. May include binding parameters.
        /// </summary>
        [AutoResolve]
        public string Body { get; set; }
    }
}
