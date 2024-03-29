﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class CurrentDutyGuardEditor : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CurrentDutyGuardViewModel ViewModel
        {
            get { return (CurrentDutyGuardViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; OnViewModelChanged(); }
        }

        private void OnViewModelChanged()
        {
            dutyGuards.DataSource = ViewModel.AllGuards;
        }

        public CurrentDutyGuardEditor()
        {
            InitializeComponent();
        }
    }
}
