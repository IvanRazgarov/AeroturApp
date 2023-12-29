using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels
{
    internal class LoadingConfirmationMessage : ValueChangedMessage<bool>
    {
        public LoadingConfirmationMessage(bool value) : base(value)
        {

        }
    }
}
