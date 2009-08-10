﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class ResidenceUnitSearchRequest
    {
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }

        public bool IsSpecified
        {
            get { return !string.IsNullOrEmpty(BlockNumber) || !string.IsNullOrEmpty(UnitNumber); }
        }
    }
}