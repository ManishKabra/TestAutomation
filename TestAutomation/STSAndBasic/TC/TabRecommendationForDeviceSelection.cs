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
    ///The TabRecommendationForDeviceSelection recording.
    /// </summary>
    [TestModule("61718bac-183c-4388-88df-6e30d809f16b", ModuleType.Recording, 1)]
    public partial class TabRecommendationForDeviceSelection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static TabRecommendationForDeviceSelection instance = new TabRecommendationForDeviceSelection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabRecommendationForDeviceSelection()
        {
            LastName = "RunP";
            FirstName = "WithAudi";
            AUPoints = "500,40;1000,45;2000,50;4000,60";
            HIName = "Run P";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabRecommendationForDeviceSelection Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("41fad5b5-3394-4ae1-a0cb-203884d19d00")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("f0bc6a67-c3fd-46c0-a074-df28fa825bec")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _AUPoints;

        /// <summary>
        /// Gets or sets the value of variable AUPoints.
        /// </summary>
        [TestVariable("a838e837-22e4-4923-86d3-eae7410356be")]
        public string AUPoints
        {
            get { return _AUPoints; }
            set { _AUPoints = value; }
        }

        string _HIName;

        /// <summary>
        /// Gets or sets the value of variable HIName.
        /// </summary>
        [TestVariable("e9053657-c6ca-4d61-a28c-ab96decc5715")]
        public string HIName
        {
            get { return _HIName; }
            set { _HIName = value; }
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

            // Step## Customer created with audiogram configured. Custom molds is enabled.
            //Report.Log(ReportLevel.Info, "Section", "Step## Customer created with audiogram configured. Custom molds is enabled.", new RecordItemIndex(0));
            
            TapOnSettings("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            CreatePatient(LastName, FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List. Select the existing customer
            //Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List. Select the existing customer", new RecordItemIndex(6));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer(FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomer(LastName, FirstName);
            Delay.Milliseconds(0);
            
            // Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done", new RecordItemIndex(10));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", AUPoints);
            Delay.Milliseconds(0);
            
            TabTapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Audiogram is saved - Recommendation should be @HI
            Report.Log(ReportLevel.Info, "Section", "Validation## Audiogram is saved - Recommendation should be @HI", new RecordItemIndex(16));
            
            ValidateMonauralHISelected(HIName, "Right");
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Validation## Returns to Customer list screen
            //Report.Log(ReportLevel.Info, "Section", "Validation## Returns to Customer list screen", new RecordItemIndex(19));
            
            VerifyActionBarTitle("Client List");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
