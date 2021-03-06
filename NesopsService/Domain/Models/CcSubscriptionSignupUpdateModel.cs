using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcSubscriptionSignupUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Label { get; set; }

        public long? IdSubscription { get; set; }

        public string Description { get; set; }

        public sbyte Enable { get; set; }

        public long? IdCallplan { get; set; }

        #endregion

    }
}
