using System;
using System.Collections.Generic;
using System.Text;

using UIPresenter;

namespace UIBase
{
    public abstract class UIViewerBase:IViewer
    {
        protected Presenter process;

        public UIViewerBase()
        {
            process = new Presenter(this);
        }
        public void Start()
        {
            process.Start();
        }

        public string Type
        {
            set
            {
                process.Type = value;
            }
        }

        public string Code
        {
            set 
            {
                process.Code = value;
            }
        }

        public abstract void CallRequestUserCode();
        public abstract void CallDisplayUserProfile(string[] infos);
    }
}
