﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Residence;
using Magenta.Shared.DesignByContract;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class AddBookingViewModel
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        [Browsable(false)]
        public IBookingService BookingService { get; private set; }

        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }

        [Browsable(false)]
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        public BookingEntryViewModel BookingEntryViewModel { get; private set; }

        public string BookingTitle
        {
            get { return string.Format("Book {0}", BookingEntryViewModel.Facility.Name); }
        }


        public AddBookingViewModel
            (
                IKernel kernel,
                IBookingService bookingService,
                IResidenceManager residenceManager,
                IWannaPlayContextService wannaPlayContextService
            )
        {
            Kernel = RequireArg.NotNull(kernel);
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);

            BookingEntryViewModel = Kernel.Get<BookingEntryViewModel>();
        }

        public void SaveBooking()
        {
            var currentDutyGuard = WannaPlayContextService.CurrentGuard;

            var bookingEntry = new BookingEntry
            {
                BookedAtDateTime = DateTime.UtcNow,
                BookedByGuard = currentDutyGuard,
                Facility = BookingEntryViewModel.Facility,
                Resident = GetSelectedResident(),
                Period = BookingEntryViewModel.BookingPeriod.Model,
            };

            BookingService.SaveBookingEntry(bookingEntry);
        }

        Resident GetSelectedResident()
        {
            var existingResident = ResidenceManager.GetResident(BookingEntryViewModel.Resident.FactilityCardNumber);

            var resident = existingResident ?? new Resident();

            resident.Name = BookingEntryViewModel.Resident.Name;
            resident.PassCardNumber = BookingEntryViewModel.Resident.FactilityCardNumber;
            resident.Unit = GetSelectedUnit();

            return resident;
        }

        ResidenceUnit GetSelectedUnit()
        {
            var existingUnit = ResidenceManager.GetResidenceUnit(BookingEntryViewModel.Resident.AddressBlockNumber, BookingEntryViewModel.Resident.AddressUnitNumber);

            var unit = existingUnit ?? new ResidenceUnit();

            unit.Block = BookingEntryViewModel.Resident.AddressBlockNumber;
            unit.Number = BookingEntryViewModel.Resident.AddressUnitNumber;

            return unit;
        }
    }
}
