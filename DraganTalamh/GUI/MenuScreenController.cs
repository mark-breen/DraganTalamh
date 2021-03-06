﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraganTalamh.Handlers;

namespace DraganTalamh.GUI
{
    public partial class MenuScreenController : UserControl
    {
        public MenuScreenController()
        {
            InitializeComponent();
        }

        private void OnMainScreenButtonClick(object sender, EventArgs e)
        {
            MainForm.GetInstance().RightPanel.Controls.RemoveAt(0); 
            ScreenHandler.ShowStartScreen();
        }

        private void OnRaceScreenButtonClick(object sender, EventArgs e)
        {

            ScreenHandler.ShowRaceScreen();
        }

        private void OnClassScreenButtonClick(object sender, EventArgs e)
        {

        }

        private void OnAbilityPointsScreenButtonClick(object sender, EventArgs e)
        {

        }

        private void OnClassAbilitiesButtonClick(object sender, EventArgs e)
        {

        }

        private void OnLayoutScreenButtonClick(object sender, EventArgs e)
        {

        }

        private void OnBackgroundScreenButtonClick(object sender, EventArgs e)
        {

        }

        private void OnOverviewScreenButtonClick(object sender, EventArgs e)
        {

        }
    }
}
