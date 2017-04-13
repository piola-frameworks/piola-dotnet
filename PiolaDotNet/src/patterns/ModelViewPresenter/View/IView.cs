// <copyright file="IView.cs" company="PiolaDotNet">
// Copyright (c) PiolaDotNet. All rights reserved.
// </copyright>

namespace PiolaDotNet.Patterns.ModelViewPresenter.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PiolaDotNet.Patterns.ModelViewPresenter.Model;

    public interface IViev<TViewModel>
        where TViewModel : IViewModel
    {
    }
}
