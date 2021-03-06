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

namespace STSAndBasic.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TabMonauralFlowRecommendationNotGiven recording.
    /// </summary>
    [TestModule("18c0041e-77dc-4952-a3ff-2c3d09116f58", ModuleType.Recording, 1)]
    public partial class TabMonauralFlowRecommendationNotGiven : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static TabMonauralFlowRecommendationNotGiven instance = new TabMonauralFlowRecommendationNotGiven();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabMonauralFlowRecommendationNotGiven()
        {
            H4 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabMonauralFlowRecommendationNotGiven Instance
        {
            get { return instance; }
        }

#region Variables

        string _H4;

        /// <summary>
        /// Gets or sets the value of variable H4.
        /// </summary>
        [TestVariable("3fb7d5a5-a010-4238-b79d-d2cc8f94ec5a")]
        public string H4
        {
            get { return _H4; }
            set { _H4 = value; }
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

            // Step## Pre-Condition - Initial setup and Access code setup is done. Customer created with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-Condition - Initial setup and Access code setup is done. Customer created with audiogram configured", new RecordItemIndex(0));
            
            TapOnSettings("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            CreatePatient("RecomNot", "Monaural");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List and select existing Customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List and select existing Customer", new RecordItemIndex(6));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("Monaural");
            Delay.Milliseconds(0);
            
            SelectCustomer("RecomNot", "Monaural");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram -Right with values 10, 10, 10, 10 dB for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram -Right with values 10, 10, 10, 10 dB for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz", new RecordItemIndex(10));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,10;1000,10;2000,10;4000,10");
            Delay.Milliseconds(0);
            
            TabTapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Pop up appears to enter values for left ear.
            Report.Log(ReportLevel.Info, "Section", "Validation## Pop up appears to enter values for left ear.", new RecordItemIndex(14));
            
            ValidateALertMessage("Do you want to enter values for the \"right\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Press No for the popup appeared
            Report.Log(ReportLevel.Info, "Section", "Step## Press No for the popup appeared", new RecordItemIndex(16));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("For this hearing loss our hearing instruments might not be optimally suited. Based on your expertise you may continue anyway.");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            // Validation## Returns to the overview screen with audiogram displayed but no recommendation made; subsequent workflow steps disabled.
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the overview screen with audiogram displayed but no recommendation made; subsequent workflow steps disabled.", new RecordItemIndex(20));
            
            ValidateWorkflowEnabled("Select Hearing Aid", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Select Sound Profile", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Fit Coupling", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Assemble Hearing Aid", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Send Data to Hearing Aid", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Check Sound Comfort", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            // Step## Manually select the Hearing Aid - Select Fit Right ear
            Report.Log(ReportLevel.Info, "Section", "Step## Manually select the Hearing Aid - Select Fit Right ear", new RecordItemIndex(27));
            
            TapOn("Select Hearing Aid");
            Delay.Milliseconds(0);
            
            // Validation## Other ear side shall not be available for selection but grayed out.
            Report.Log(ReportLevel.Info, "Section", "Validation## Other ear side shall not be available for selection but grayed out.", new RecordItemIndex(29));
            
            ValidateRecommendationEnabled("Right", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            ValidateRecommendationEnabled("Left", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            // Step## Select Fit Right ear
            Report.Log(ReportLevel.Info, "Section", "Step## Select Fit Right ear", new RecordItemIndex(32));
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            // Validation## Supported HI type are listed Run P and SP with their fitting range and plotted points visible in the graph
            Report.Log(ReportLevel.Info, "Section", "Validation## Supported HI type are listed Run P and SP with their fitting range and plotted points visible in the graph", new RecordItemIndex(34));
            
            ValidateContentsContains("Run Click CIC;Run Click ITC;Run P;Run SP", ValueConverter.ArgumentFromString<bool>("isFound", "True"));
            Delay.Milliseconds(0);
            
            // Step## Select HI as Run Click CIC
            Report.Log(ReportLevel.Info, "Section", "Step## Select HI as Run Click CIC", new RecordItemIndex(36));
            
            BackAction();
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            TapOn(H4);
            Delay.Milliseconds(0);
            
            // Validation## Returns to the overview screen with the recommendation made and Send data to HI highlighted.
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the overview screen with the recommendation made and Send data to HI highlighted.", new RecordItemIndex(40));
            
            ValidateMonauralHISelected(H4, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P1", "Right");
            Delay.Milliseconds(0);
            
            // Step## Click on cluster to change from P1 to P2
            Report.Log(ReportLevel.Info, "Section", "Step## Click on cluster to change from P1 to P2", new RecordItemIndex(44));
            
            TapOn("P1");
            Delay.Milliseconds(0);
            
            TapOn("P2");
            Delay.Milliseconds(0);
            
            // Validation## P2 is selected
            Report.Log(ReportLevel.Info, "Section", "Validation## P2 is selected", new RecordItemIndex(47));
            
            ValidateMonauralClusterSelected("P2", "Right");
            Delay.Milliseconds(0);
            
            // Step## Navigate back to overview screen. Verify Coupling type remains as Click Sleeve
            Report.Log(ReportLevel.Info, "Section", "Step## Navigate back to overview screen. Verify Coupling type remains as Click Sleeve", new RecordItemIndex(49));
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Right");
            Delay.Milliseconds(0);
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect-Pair HI
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect-Pair HI", new RecordItemIndex(52));
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output. HI is successfully paired
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output. HI is successfully paired", new RecordItemIndex(53));
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            ValidateALertMessage(" Selected Sound Profile provides higher amplification than the recommended Profile. Are you sure of your selection?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            TapOn("Yes");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            // Step## Press Sound Comfort and adjust sound and Volume sliders
            Report.Log(ReportLevel.Info, "Section", "Step## Press Sound Comfort and adjust sound and Volume sliders", new RecordItemIndex(59));
            
            // Validation## Sliders are adjusted accordingly
            Report.Log(ReportLevel.Info, "Section", "Validation## Sliders are adjusted accordingly", new RecordItemIndex(60));
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            //VolumeIncrease();
            //Delay.Milliseconds(0);
            
            //SoundSharper();
            //Delay.Milliseconds(0);
            
            // Step## Press Test OK
            Report.Log(ReportLevel.Info, "Section", "Step## Press Test OK", new RecordItemIndex(64));
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            // Validation## Fitting Session completed
            Report.Log(ReportLevel.Info, "Section", "Validation## Fitting Session completed", new RecordItemIndex(66));
            
            TabVerifyActionBarDetailTitle("Session Completed");
            Delay.Milliseconds(0);
            
            // Step## Press Close session
            Report.Log(ReportLevel.Info, "Section", "Step## Press Close session", new RecordItemIndex(68));
            
            CloseSession();
            Delay.Milliseconds(0);
            
            // Validation## Returns to the Customer List screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the Customer List screen", new RecordItemIndex(70));
            
            VerifyActionBarTitle("Client List");
            Delay.Milliseconds(0);
            
            TapOnSettings("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
