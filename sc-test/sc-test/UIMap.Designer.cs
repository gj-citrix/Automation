﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace sc_test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Threading;
    using System.Diagnostics;
    using System.Linq;

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {

        /// <summary>
        /// cancelbutton - Use 'cancelbuttonParams' to pass parameters into this method.
        /// </summary>
        private log4net.ILog log;

        public void cancelbutton()
        {
            MyLogHelper myLog = new MyLogHelper(System.Reflection.MethodBase.GetCurrentMethod());
            log = myLog.Logger;

            #region Variable Declarations
            WpfCustom uISettingBladeCustom = this.UIShareConnectWindow.UIBladeViewControlCustom.UISettingBladeCustom;
            WpfButton uICancelButton = this.UIShareConnectWindow1.UIMainTabControlTabList.UIRDUWGJWANG01TabPage.UIWinformHostPane.UIItemClient.UIWpfWindow.UIItemCustom.UICancelButton;
            WinButton uICloseButton = this.UIShareConnectWindow1.UICloseButton;

            UIItemCustom x = this.UIShareConnectWindow1.UIMainTabControlTabList.UIRDUWGJWANG01TabPage.UIWinformHostPane.UIItemClient.UIWpfWindow.UIItemCustom;
            #endregion

            log.Info("launch DA!!!");
            // Launch '%LOCALAPPDATA%\Citrix\ShareConnectDesktopApp\ShareConnect.Client.WindowsDesktop.exe'
            ApplicationUnderTest shareConnectClientWindowsDesktopApplication = ApplicationUnderTest.Launch(this.cancelbuttonParams.ExePath, this.cancelbuttonParams.AlternateExePath);
            Thread.Sleep(5000);
            log.Info("DA is up!!!");

            // Click 'SettingBlade' custom control
            log.Info("NOT Click SettingBlade!!!");
            // Mouse.Click(uISettingBladeCustom, new Point(94, 115));
            //Thread.Sleep(8000);

            // Click 'Cancel' button
            log.Info("Click CancelButton!!!");
            Mouse.Click(uICancelButton, new Point(78, 14));
            log.Debug("Test done!!!");

            //Debug.WriteLine("********************************************************");
            //Debug.WriteLine("===========" + x.TryFind().ToString() + "=====================");

            //UITestControlCollection tmp = x.FindMatchingControls();
            //Debug.WriteLine(tmp.Count);

            //var controls = tmp.Select(y => y.Name);
            //foreach (var control in controls)
            //{
            //    Debug.WriteLine(control.ToString());
            //}
            //Debug.WriteLine("********************************************************");

            // Click 'Close' button
            //Mouse.Click(uICloseButton, new Point(25, 14));
        }

        #region Properties
        public virtual cancelbuttonParams cancelbuttonParams
        {
            get
            {
                if ((this.mcancelbuttonParams == null))
                {
                    this.mcancelbuttonParams = new cancelbuttonParams();
                }
                return this.mcancelbuttonParams;
            }
        }
        
        public UIShareConnectWindow UIShareConnectWindow
        {
            get
            {
                if ((this.mUIShareConnectWindow == null))
                {
                    this.mUIShareConnectWindow = new UIShareConnectWindow();
                }
                return this.mUIShareConnectWindow;
            }
        }
        
        public UIShareConnectWindow1 UIShareConnectWindow1
        {
            get
            {
                if ((this.mUIShareConnectWindow1 == null))
                {
                    this.mUIShareConnectWindow1 = new UIShareConnectWindow1();
                }
                return this.mUIShareConnectWindow1;
            }
        }
        #endregion
        
        #region Fields
        private cancelbuttonParams mcancelbuttonParams;
        
        private UIShareConnectWindow mUIShareConnectWindow;
        
        private UIShareConnectWindow1 mUIShareConnectWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'cancelbutton'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class cancelbuttonParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%LOCALAPPDATA%\Citrix\ShareConnectDesktopApp\ShareConnect.Client.WindowsDesktop.exe'
        /// </summary>
        public string ExePath = "C:\\Users\\gwojiehw\\AppData\\Local\\Citrix\\ShareConnectDesktopApp\\ShareConnect.Client" +
            ".WindowsDesktop.exe";
        
        /// <summary>
        /// Launch '%LOCALAPPDATA%\Citrix\ShareConnectDesktopApp\ShareConnect.Client.WindowsDesktop.exe'
        /// </summary>
        public string AlternateExePath = "%LOCALAPPDATA%\\Citrix\\ShareConnectDesktopApp\\ShareConnect.Client.WindowsDesktop.e" +
            "xe";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShareConnectWindow : WpfWindow
    {
        
        public UIShareConnectWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "ShareConnect";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIBladeViewControlCustom UIBladeViewControlCustom
        {
            get
            {
                if ((this.mUIBladeViewControlCustom == null))
                {
                    this.mUIBladeViewControlCustom = new UIBladeViewControlCustom(this);
                }
                return this.mUIBladeViewControlCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIBladeViewControlCustom mUIBladeViewControlCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBladeViewControlCustom : WpfCustom
    {
        
        public UIBladeViewControlCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.MultiSessionBladeView";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "BladeViewControl";
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public WpfCustom UISettingBladeCustom
        {
            get
            {
                if ((this.mUISettingBladeCustom == null))
                {
                    this.mUISettingBladeCustom = new WpfCustom(this);
                    #region Search Criteria
                    this.mUISettingBladeCustom.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SettingsBlade";
                    this.mUISettingBladeCustom.SearchProperties[WpfControl.PropertyNames.AutomationId] = "SettingBlade";
                    this.mUISettingBladeCustom.WindowTitles.Add("ShareConnect");
                    #endregion
                }
                return this.mUISettingBladeCustom;
            }
        }
        #endregion
        
        #region Fields
        private WpfCustom mUISettingBladeCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShareConnectWindow1 : WinWindow
    {
        
        public UIShareConnectWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShareConnect";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIMainTabControlTabList UIMainTabControlTabList
        {
            get
            {
                if ((this.mUIMainTabControlTabList == null))
                {
                    this.mUIMainTabControlTabList = new UIMainTabControlTabList(this);
                }
                return this.mUIMainTabControlTabList;
            }
        }
        
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("ShareConnect");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private UIMainTabControlTabList mUIMainTabControlTabList;
        
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMainTabControlTabList : WpfTabList
    {
        
        public UIMainTabControlTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "MainTabControl";
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIRDUWGJWANG01TabPage UIRDUWGJWANG01TabPage
        {
            get
            {
                if ((this.mUIRDUWGJWANG01TabPage == null))
                {
                    this.mUIRDUWGJWANG01TabPage = new UIRDUWGJWANG01TabPage(this);
                }
                return this.mUIRDUWGJWANG01TabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIRDUWGJWANG01TabPage mUIRDUWGJWANG01TabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRDUWGJWANG01TabPage : WpfTabPage
    {
        
        public UIRDUWGJWANG01TabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "RDUWGJWANG01";
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIWinformHostPane UIWinformHostPane
        {
            get
            {
                if ((this.mUIWinformHostPane == null))
                {
                    this.mUIWinformHostPane = new UIWinformHostPane(this);
                }
                return this.mUIWinformHostPane;
            }
        }
        #endregion
        
        #region Fields
        private UIWinformHostPane mUIWinformHostPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIWinformHostPane : WpfPane
    {
        
        public UIWinformHostPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfPane.PropertyNames.ClassName] = "Uia.WindowsFormsHost";
            this.SearchProperties[WpfPane.PropertyNames.AutomationId] = "WinformHost";
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIItemClient UIItemClient
        {
            get
            {
                if ((this.mUIItemClient == null))
                {
                    this.mUIItemClient = new UIItemClient(this);
                }
                return this.mUIItemClient;
            }
        }
        #endregion
        
        #region Fields
        private UIItemClient mUIItemClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemClient : WinClient
    {
        
        public UIItemClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";
            this.WindowTitles.Add("ShareConnect");
            #endregion
        }
        
        #region Properties
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow(this);
                }
                return this.mUIWpfWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIWpfWindow mUIWpfWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Login to your server";
            this.SearchProperties[WpfWindow.PropertyNames.ControlType] = "Window";
            this.WindowTitles.Add("ShareConnect");
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShareConnect";
            #endregion
        }

        #region Properties
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIItemCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemCustom : WpfCustom
    {
        
        public UIItemCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.ComputerLoginControl";
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "Custom";
            this.WindowTitles.Add("ShareConnect");
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShareConnect";
            #endregion
        }

        #region Properties
        public WpfButton UICancelButton
        {
            get
            {
                if ((this.mUICancelButton == null))
                {
                    this.mUICancelButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICancelButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "CancelButton";
                    this.mUICancelButton.WindowTitles.Add("ShareConnect");
                    #endregion
                }
                return this.mUICancelButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUICancelButton;
        #endregion
    }
}
