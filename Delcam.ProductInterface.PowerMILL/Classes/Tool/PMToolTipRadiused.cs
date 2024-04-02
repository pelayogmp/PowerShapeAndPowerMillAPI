// **********************************************************************
// *         � COPYRIGHT 2018 Autodesk, Inc.All Rights Reserved         *
// *                                                                    *
// *  Use of this software is subject to the terms of the Autodesk      *
// *  license agreement provided at the time of installation            *
// *  or download, or which otherwise accompanies this software         *
// *  in either electronic or hard copy form.                           *
// **********************************************************************

using System;
using Autodesk.Geometry;

namespace Autodesk.ProductInterface.PowerMILL
{
    /// <summary>
    /// Represents a tip radiused tool in PowerMill.
    /// </summary>
    /// <remarks></remarks>
    public class PMToolTipRadiused : PMTool
    {
        #region Constructors

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        internal PMToolTipRadiused(PMAutomation powerMILL) : base(powerMILL)
        {
        }

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        /// <param name="name">The new instance name.</param>
        internal PMToolTipRadiused(PMAutomation powerMILL, string name) : base(powerMILL, name)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the tip radius of a tip radiused tool.
        /// </summary>
        public MM TipRadius
        {
            get
            {
                return
                    Convert.ToDouble(
                        PowerMill.GetPowerMillEntityParameter("tool", Name, "tipradius").Trim());
            }
            set { PowerMill.DoCommand("EDIT TOOL \"" + Name + "\" TIPRADIUS " + value, "TOOL ACCEPT"); }
        }

        #endregion
    }
}