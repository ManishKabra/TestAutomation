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

namespace STSAndTouchControl.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FirstSetUptouchControlApplicationCancelAndRetry recording.
    /// </summary>
    [TestModule("18764e08-028f-4bb5-b13f-f6d991128838", ModuleType.Recording, 1)]
    public partial class FirstSetUptouchControlApplicationCancelAndRetry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndTouchControl.STSAndTouchControlRepository repository.
        /// </summary>
        public static STSAndTouchControl.STSAndTouchControlRepository repo = STSAndTouchControl.STSAndTouchControlRepository.Instance;

        static FirstSetUptouchControlApplicationCancelAndRetry instance = new FirstSetUptouchControlApplicationCancelAndRetry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FirstSetUptouchControlApplicationCancelAndRetry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FirstSetUptouchControlApplicationCancelAndRetry Instance
        {
            get { return instance; }
        }

#region Variables

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

            // Step## Click on SetUp
            Report.Log(ReportLevel.Info, "Section", "Step## Click on SetUp", new RecordItemIndex(0));
            
            TapOnSettings();
            Delay.Milliseconds(0);
            
            TapOn("Setup");
            Delay.Milliseconds(0);
            
            // Validation## Setup screen appears with two options Scan QR Code and Manual setup
            Report.Log(ReportLevel.Info, "Section", "Validation## Setup screen appears with two options Scan QR Code and Manual setup", new RecordItemIndex(3));
            
            ValidateContents("Scan QR Code;Manual Setup");
            Delay.Milliseconds(0);
            
            // Step## Press  Manual Setup
            Report.Log(ReportLevel.Info, "Section", "Step## Press  Manual Setup", new RecordItemIndex(5));
            
            TapOn("Manual Setup");
            Delay.Milliseconds(0);
            
            PermissionPopUpHandle();
            Delay.Milliseconds(0);
            
            // Validtaion## Setup screen is displayed.The app provides option to distinguish between standard HI set up and MF HI set up Setup screen has two options: 1. Signia Products 2. Signia Run Products
            Report.Log(ReportLevel.Info, "Section", "Validtaion## Setup screen is displayed.The app provides option to distinguish between standard HI set up and MF HI set up Setup screen has two options: 1. Signia Products 2. Signia Run Products", new RecordItemIndex(8));
            
            ValidateContents("Signia Products;Signia Run Products");
            Delay.Milliseconds(0);
            
            // Step## Select the option "Signia Products" for standard HI set up
            Report.Log(ReportLevel.Info, "Section", "Step## Select the option \"Signia Products\" for standard HI set up", new RecordItemIndex(10));
            
            TapOn("Signia Products");
            Delay.Milliseconds(0);
            
            // Step## Press back button to Cancel
            Report.Log(ReportLevel.Info, "Section", "Step## Press back button to Cancel", new RecordItemIndex(12));
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Validation## Setup process is cancelled.
            Report.Log(ReportLevel.Info, "Section", "Validation## Setup process is cancelled.", new RecordItemIndex(14));
            
            ValidateContents("Signia Products;Signia Run Products");
            Delay.Milliseconds(0);
            
            // Step##Select Signia Products again in the set up screen
            Report.Log(ReportLevel.Info, "Section", "Step##Select Signia Products again in the set up screen", new RecordItemIndex(16));
            
            TapOn("Signia Products");
            Delay.Milliseconds(0);
            
            // Step##Select NO in the Confirmation tone screen
            Report.Log(ReportLevel.Info, "Section", "Step##Select NO in the Confirmation tone screen", new RecordItemIndex(18));
            
            TapOn("No");
            Delay.Milliseconds(0);
            
            // Validation## Setup process is cancelled and starts over again
            Report.Log(ReportLevel.Info, "Section", "Validation## Setup process is cancelled and starts over again", new RecordItemIndex(20));
            
            ValidateContents("Signia Products;Signia Run Products");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
