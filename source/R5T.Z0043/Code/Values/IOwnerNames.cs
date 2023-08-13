using System;

using R5T.T0131;
using R5T.T0186;
using R5T.T0186.Extensions;


namespace R5T.Z0043
{
    /// <summary>
    /// Repository owner names.
    /// </summary>
    [ValuesMarker]
    public partial interface IOwnerNames : IValuesMarker
    {
        /// <summary>
        /// "davidcoats"
        /// </summary>
        public const string DavidCoats_Constant = "davidcoats";

        /// <inheritdoc cref="DavidCoats_Constant"/>
        public IOwnerName DavidCoats => "davidcoats".ToOwnerName();

        /// <summary>
        /// "SafetyCone"
        /// </summary>
        public const string SafetyCone_Constant = "SafetyCone";

        /// <inheritdoc cref="SafetyCone_Constant"/>
        public IOwnerName SafetyCone => "SafetyCone".ToOwnerName();
    }
}
