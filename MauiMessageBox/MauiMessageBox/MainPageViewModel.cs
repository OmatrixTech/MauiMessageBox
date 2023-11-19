using CustomControls.MAUI.MessageBox.AppPresentations.CustomMessageBox;
using CustomControls.MAUI.MessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMessageBox
{
    public class MainPageViewModel
    {
        public ICommand AlertCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }
        public ICommand SelfCommand { get; set; }
        IModalMessageBoxServiceHandler modalMessageBoxServiceHandler = null;
        public MainPageViewModel(IModalMessageBoxServiceHandler modalMessageBoxServiceHandler)
        {
            this.modalMessageBoxServiceHandler = modalMessageBoxServiceHandler;
            AlertCommand = new Command(() => AlertPopupCommand());
            ConfirmCommand = new Command(() => ConfirmPopupCommand());
            SelfCommand = new Command(() => SelfPopupCommand());
        }
        private void AlertPopupCommand()
        {

            //Message box method without using an instance.
            //CustomAlertMessageBox customAlertMessageBoxWithoutInstance = ModalMessageBoxHandler.GetCustomMessageBox(messageTitle: "Demo", messageText: "Test messagebox", messageBoxButtonText: "Ok");
            //customAlertMessageBoxWithoutInstance.OkButtonEventHandler += (sender, obj) =>
            //{

            //};

            //Method for injecting dependencies using a service for the message box.
            CustomAlertMessageBox customAlertMessageBox = modalMessageBoxServiceHandler.GetCustomMessageBox(messageTitle: "Information", messageText: "The MIT License (MIT)\r\n\r\nCopyright (c) [2023] [Sanjay kumar jha]\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy\r\nof this software and associated documentation files (the \"Software\"), to deal\r\nin the Software without restriction, including without limitation the rights\r\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\r\ncopies of the Software, and to permit persons to whom the Software is\r\nfurnished to do so, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all\r\ncopies or substantial portions of the Software.\r\n\r\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.\r\n\r\n\r\n\r\nA Xamarin message box, often referred to as a dialog box or alert box, is a user interface element in software \r\napplications used to display information, prompt the user for input, or provide notifications. \r\nIt serves specific functions and has distinct requirements to enhance user interaction. \r\n", messageBoxButtonText: "OK");
            customAlertMessageBox.OkButtonEventHandler += (sender, obj) =>
            {

            };


        }
        private void ConfirmPopupCommand()
        {

            //Message box method without using an instance.
            //CustomConfirmMessageBox customConfirmMessageBoxWithoutInstance = ModalMessageBoxHandler.GetConfirmationMessageBox(messageTitle: "Demo",messageText: "Test messagebox",messageBoxFirstButtonText: "Ok",messageBoxButtonSecondText: "Cancel");
            //customConfirmMessageBoxWithoutInstance.YesButtonEventHandler += (sender, obj) =>
            //{

            //};
            //customConfirmMessageBoxWithoutInstance.NoButtonEventHandler += (sender, obj) =>
            //{

            //};

            //Method for injecting dependencies using a service for the message box.
            CustomConfirmMessageBox customConfirmMessageBox = modalMessageBoxServiceHandler.GetConfirmationMessageBox(messageTitle: "Confirmation", messageText: "The MIT License (MIT)\r\n\r\nCopyright (c) [2023] [Sanjay kumar jha]\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy\r\nof this software and associated documentation files (the \"Software\"), to deal\r\nin the Software without restriction, including without limitation the rights\r\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\r\ncopies of the Software, and to permit persons to whom the Software is\r\nfurnished to do so, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all\r\ncopies or substantial portions of the Software.\r\n\r\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.\r\n\r\n\r\n\r\nA Xamarin message box, often referred to as a dialog box or alert box, is a user interface element in software \r\napplications used to display information, prompt the user for input, or provide notifications. \r\nIt serves specific functions and has distinct requirements to enhance user interaction. \r\n", messageBoxFirstButtonText: "YES", messageBoxButtonSecondText: "NO");
            customConfirmMessageBox.YesButtonEventHandler += (sender, obj) =>
            {

            };
            customConfirmMessageBox.NoButtonEventHandler += (sender, obj) =>
            {

            };
        }
        private void SelfPopupCommand()
        {
            SampleCustomMessageBox myCustomPopup = new SampleCustomMessageBox();

            //Message box method without using an instance.

            //ModalMessageBoxHandler.ShowOwnCustomPopup(myCustomPopup);

            //Method for injecting dependencies using a service for the message box.
            modalMessageBoxServiceHandler.ShowCustomOwnPopup(myCustomPopup);
        }
    }
}
