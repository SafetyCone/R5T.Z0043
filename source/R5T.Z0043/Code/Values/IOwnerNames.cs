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
        public IOwnerName DavidCoats => "davidcoats".ToOwnerName();
        public IOwnerName SafetyCone => "SafetyCone".ToOwnerName();
    }
}
