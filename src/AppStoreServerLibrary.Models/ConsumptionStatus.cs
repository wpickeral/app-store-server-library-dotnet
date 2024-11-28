using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A value that indicates the extent to which the customer consumed the in-app purchase.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/consumptionstatus">consumptionStatus</a>
/// </remarks>
public enum ConsumptionStatus
{
    /// <summary>
    /// The consumption status is undeclared.
    /// </summary>
    Undeclared = 0,

    /// <summary>
    /// The in-app purchase has not been consumed.
    /// </summary>
    NotConsumed = 1,

    /// <summary>
    /// The in-app purchase has been partially consumed.
    /// </summary>
    PartiallyConsumed = 2,

    /// <summary>
    /// The in-app purchase has been fully consumed.
    /// </summary>
    FullyConsumed = 3
}
