﻿using AppDynamics.Dexter.ReportObjects;
using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjectMaps
{
    public class WEBPageToBusinessTransactionReportMap : ClassMap<WEBPageToBusinessTransaction>
    {
        public WEBPageToBusinessTransactionReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;

            Map(m => m.PageType).Index(i); i++;

            Map(m => m.PageName).Index(i); i++;

            Map(m => m.TierName).Index(i); i++;
            Map(m => m.BTName).Index(i); i++;
            Map(m => m.BTType).Index(i); i++;

            Map(m => m.ART).Index(i); i++;
            Map(m => m.ARTRange).Index(i); i++;
            Map(m => m.Calls).Index(i); i++;
            Map(m => m.CPM).Index(i); i++;

            Map(m => m.HasActivity).Index(i); i++;
            Map(m => m.From).Index(i); i++;
            Map(m => m.To).Index(i); i++;
            Map(m => m.FromUtc).Index(i); i++;
            Map(m => m.ToUtc).Index(i); i++;
            Map(m => m.Duration).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.PageID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.BTID).Index(i); i++;

            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
        }
    }
}