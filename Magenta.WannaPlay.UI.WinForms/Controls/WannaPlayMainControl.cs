﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.Services.Residence;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class WannaPlayMainControl : UserControl
    {
        public WannaPlayMainControl()
        {
            InitializeComponent();
        }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Inject]
        public IKernel Kernel { get; set; }

        private void WannaPlayMainControl_Load(object sender, EventArgs e)
        {
            // TODO: Remove hardcoding
            facilityBookingControl1.ViewModel = Kernel.Get<GranularScheduleFacilityBookingViewModel>();
        }
    }
}
