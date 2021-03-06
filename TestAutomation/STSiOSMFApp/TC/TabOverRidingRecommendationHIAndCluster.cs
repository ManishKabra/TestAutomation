﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSiOSMFApp.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TabOverRidingRecommendationHIAndCluster recording.
    /// </summary>
    [TestModule("59b3eb21-dffd-4b6f-8e16-661232a3b102", ModuleType.Recording, 1)]
    public partial class TabOverRidingRecommendationHIAndCluster : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabOverRidingRecommendationHIAndCluster instance = new TabOverRidingRecommendationHIAndCluster();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabOverRidingRecommendationHIAndCluster()
        {
            H1 = "";
            H2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabOverRidingRecommendationHIAndCluster Instance
        {
            get { return instance; }
        }

#region Variables

        string _H1;

        /// <summary>
        /// Gets or sets the value of variable H1.
        /// </summary>
        [TestVariable("63914a92-fd7e-4d50-926a-c116070ca549")]
        public string H1
        {
            get { return _H1; }
            set { _H1 = value; }
        }

        string _H2;

        /// <summary>
        /// Gets or sets the value of variable H2.
        /// </summary>
        [TestVariable("0b9de534-72cf-44cf-8678-9193d62b0864")]
        public string H2
        {
            get { return _H2; }
            set { _H2 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Step## Pre-Condition - Initial setup and Access code setup is done.Customer created with audiogram configured with monaural audiogram(Right) -Prefilled recommendation done
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-Condition - Initial setup and Access code setup is done.Customer created with audiogram configured with monaural audiogram(Right) -Prefilled recommendation done", new RecordItemIndex(0));
            
            TapOn("SettingsIcon");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            TapOn("ClientIcon");
            Delay.Milliseconds(0);
            
            CreatePatient("OverRiding", "Recommendation");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,60;1000,65;2000,85;4000,90");
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            SelectPage("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Selected Sound Profile has high amplification output.");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            TapOn("Yes");
            Delay.Milliseconds(0);
            
            TapOn("OK");
            Delay.Milliseconds(0);
            
            SelectPage("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Session Completed");
            Delay.Milliseconds(0);
            
            CloseSession();
            Delay.Milliseconds(0);
            
            TabVerifyNavBarTitle("Client List");
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the App and go to List, Select the customer
            //Report.Log(ReportLevel.Info, "Section", "Step## Open the App and go to List, Select the customer", new RecordItemIndex(23));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("Recommendation");
            Delay.Milliseconds(0);
            
            SelectCustomer("OverRiding", "Recommendation");
            Delay.Milliseconds(0);
            
            // Validation## Overview screen is displayed for the selected customer
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen is displayed for the selected customer", new RecordItemIndex(27));
            
            TabVerifyNavBarFititngTitle("OverRiding, Recommendation");
            Delay.Milliseconds(0);
            
            // Step## Select the HI tab -Select right ear
            Report.Log(ReportLevel.Info, "Section", "Step## Select the HI tab -Select right ear", new RecordItemIndex(29));
            
            TapOnWithValue(H1);
            Delay.Milliseconds(0);
            
            TapOnWithValue("Fit right ear with hearing ");
            Delay.Milliseconds(0);
            
            // Validation## HI screen is opened with list of available HI's- CIC, ITC Run P, Run SP and recommended HI is displayed.
            Report.Log(ReportLevel.Info, "Section", "Validation## HI screen is opened with list of available HI's- CIC, ITC Run P, Run SP and recommended HI is displayed.", new RecordItemIndex(32));
            
            ValidateContents("Run Click CIC;Run Click ITC;Run P;Run SP");
            Delay.Milliseconds(0);
            
            ValidateRecommendedHI(H1, "Right");
            Delay.Milliseconds(0);
            
            // Step## Select the HI other than recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Select the HI other than recommended", new RecordItemIndex(35));
            
            TapOnWithSwipe(H2);
            Delay.Milliseconds(0);
            
            // Validation## Coupling screen is displayed with recommendation based on HI selected(i.e Tip for Run P)
            Report.Log(ReportLevel.Info, "Section", "Validation## Coupling screen is displayed with recommendation based on HI selected(i.e Tip for Run P)", new RecordItemIndex(37));
            
            ValidateRecommendedCoupling("Tip", "Right");
            Delay.Milliseconds(0);
            
            // Step## Select Coupling Type other than recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Select Coupling Type other than recommended", new RecordItemIndex(39));
            
            TapOn("Custom Mold");
            Delay.Milliseconds(0);
            
            // Validation## Automatically directs the overview screen with the corresponding new selections of -HI,Coupling type and recommended cluster is displayed.
            Report.Log(ReportLevel.Info, "Section", "Validation## Automatically directs the overview screen with the corresponding new selections of -HI,Coupling type and recommended cluster is displayed.", new RecordItemIndex(41));
            
            TabVerifyNavBarFititngTitle("OverRiding, Recommendation");
            Delay.Milliseconds(0);
            
            ValidateMonauralHISelected(H2, "");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Custom Mold", "");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P1", "");
            Delay.Milliseconds(0);
            
            // Step## Click on cluster in overview screen
            Report.Log(ReportLevel.Info, "Section", "Step## Click on cluster in overview screen", new RecordItemIndex(46));
            
            TapOnWithValue("P1");
            Delay.Milliseconds(0);
            
            // Validation## The app shall highlight the matching cluster as “suitable”.
            Report.Log(ReportLevel.Info, "Section", "Validation## The app shall highlight the matching cluster as “suitable”.", new RecordItemIndex(48));
            
            ValidateSuitableCluster("P1", "Right");
            Delay.Milliseconds(0);
            
            // Step## Select any other cluster other than recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Select any other cluster other than recommended", new RecordItemIndex(50));
            
            TapOn("P2");
            Delay.Milliseconds(0);
            
            // Validation## New cluster is selected and displayed in overview screen
            Report.Log(ReportLevel.Info, "Section", "Validation## New cluster is selected and displayed in overview screen", new RecordItemIndex(52));
            
            TabVerifyNavBarFititngTitle("OverRiding, Recommendation");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P2", "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
