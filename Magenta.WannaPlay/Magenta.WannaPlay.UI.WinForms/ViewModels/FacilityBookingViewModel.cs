﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class FacilityBookingViewModel : INotifyPropertyChanged
    {
        public BindingList<FacilityBookingSlot> BookingEntries { get; private set; }
        public IGranularScheduleBookingService BookingService { get; private set; }
        public DateTimePeriod Period { get; set; }
        public Facility Facility { get; set; }


        public FacilityBookingViewModel(IGranularScheduleBookingService bookingService)
        {
            BookingService = RequireArg.NotNull(bookingService);

            // TODO: Parametrize
            Facility = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One", Id = 1 };
            Period = DateTimePeriod.FromDays(DateTime.UtcNow.AddDays(-1), 1);

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            BookingEntries = BookingService.GetBookings(Period, Facility).ToBindingList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}