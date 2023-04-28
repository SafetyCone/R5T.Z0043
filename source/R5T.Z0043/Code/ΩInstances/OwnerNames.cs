using System;


namespace R5T.Z0043
{
    public class OwnerNames : IOwnerNames
    {
        #region Infrastructure

        public static IOwnerNames Instance { get; } = new OwnerNames();


        private OwnerNames()
        {
        }

        #endregion
    }
}
