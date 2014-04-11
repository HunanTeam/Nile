using Nile.Core.Domain.Customers;
using Nile.Core.Domain.Discounts;
using Nile.Core.Domain.Stores;

namespace Nile.Services.Discounts
{
    /// <summary>
    /// Represents a discount requirement request
    /// </summary>
    public partial class CheckDiscountRequirementRequest
    {
        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public DiscountRequirement DiscountRequirement { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the store
        /// </summary>
        public Store Store { get; set; }
    }
}
