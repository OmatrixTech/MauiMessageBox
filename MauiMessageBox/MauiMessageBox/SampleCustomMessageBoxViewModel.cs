using CustomControls.MAUI.MessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMessageBox
{
    public class SampleCustomMessageBoxViewModel
    {
        public ICommand CloseCommand { get; set; }
        IModalMessageBoxServiceHandler modalMessageBoxServiceHandler = null;
        public SampleCustomMessageBoxViewModel(IModalMessageBoxServiceHandler modalMessageBoxServiceHandler)
        {
            this.modalMessageBoxServiceHandler = modalMessageBoxServiceHandler;
            CloseCommand = new Command(() => ClosePopup());
        }

        private void ClosePopup()
        {
            //Method for injecting dependencies using a service for the message box.
            modalMessageBoxServiceHandler.HideCustomPopup();


            //Message box method without using an instance.
            //ModalMessageBoxHandler.HideCustomPopup();
        }
    }
}
