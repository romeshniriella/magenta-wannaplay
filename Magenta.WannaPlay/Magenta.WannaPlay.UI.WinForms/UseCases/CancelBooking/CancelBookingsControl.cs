﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [DefaultBindingProperty("ViewModel")]
    public partial class CancelBookingsControl : UserControl
    {
        public CancelBookingsControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public CancelBookingViewModel ViewModel
        {
            get { return (CancelBookingViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        private void cancelSelectedBooking_Click(object sender, EventArgs e)
        {
            ViewModel.CancelSelectedBookings();
        }
    }
}