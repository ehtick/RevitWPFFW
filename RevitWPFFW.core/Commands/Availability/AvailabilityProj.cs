﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitWPFFW.core
{
    /// <summary>
    /// Availability Class for Revit Ribbon Button
    /// Returns true if is a Project Document
    /// </summary>
    public class AvailabilityProj : IExternalCommandAvailability
    {
        /// <summary>
        /// Availability Command Method
        /// </summary>
        /// <param name="uiApp">UI Application</param>
        /// <param name="selectedCategories">Category Set</param>
        /// <returns>False if Family Document</returns>
        public bool IsCommandAvailable(UIApplication uiApp, CategorySet selectedCategories)
        {
            try
            {
                Document doc = uiApp.ActiveUIDocument.Document;

                if (doc.IsFamilyDocument)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Provide constructed namespace path
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            //return constructed namespace path
            return typeof(AvailabilityProj).FullName;
        }
    }
}
