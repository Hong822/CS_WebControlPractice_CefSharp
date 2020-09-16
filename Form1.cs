using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CS_WebControlPractice_CefSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChromeBrowser();
        }

        private void InitializeChromeBrowser()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser("https://www.naver.com");
            chrome.Dock = DockStyle.Fill; //Maximize size
            this.Controls.Add(chrome);
        }
    }
}
