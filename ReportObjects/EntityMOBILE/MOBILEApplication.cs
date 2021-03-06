﻿using System;

namespace AppDynamics.Dexter.ReportObjects
{
    public class MOBILEApplication : MOBILEEntityBase
    {
        public int NumNetworkRequests { get; set; }

        public int NumActivity { get; set; }
        public int NumNoActivity { get; set; }

        public override String ToString()
        {
            return String.Format(
                "MOBILEApplication: {0}/{1}({2})",
                this.Controller,
                this.ApplicationName,
                this.ApplicationID);
        }
    }
}
