﻿using System;
using Acr;
using ReactiveUI;


namespace LocationWarning.ViewModels
{
    public abstract class AbstractViewModel : ReactiveObject, IViewModelLifecycle
    {
        public virtual void OnActivate()
        {
        }


        public virtual void OnDeactivate()
        {
        }


        public virtual bool OnBack()
        {
            return true;
        }
    }
}
