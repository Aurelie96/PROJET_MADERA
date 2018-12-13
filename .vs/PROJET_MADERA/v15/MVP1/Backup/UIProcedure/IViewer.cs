using System;
using System.Collections.Generic;
using System.Text;

namespace UIPresenter
{
    public interface IViewer
    {
        void CallRequestUserCode();
        void CallDisplayUserProfile();
        void CallRequestUserCode(string message);
    }
}
