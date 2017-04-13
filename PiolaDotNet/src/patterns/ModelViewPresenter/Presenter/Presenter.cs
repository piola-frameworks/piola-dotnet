// <copyright file="Presenter.cs" company="PiolaDotNet">
// Copyright (c) PiolaDotNet. All rights reserved.
// </copyright>

namespace PiolaDotNet.Patterns.ModelViewPresenter.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PiolaDotNet.Patterns.ModelViewPresenter.Model;
    using PiolaDotNet.Patterns.ModelViewPresenter.View;

    /// <summary>
    /// Presenter
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    public abstract class Presenter<TView>
        where TView : IViev<IViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Presenter{TView}"/> class.
        /// </summary>
        /// <param name="view"></param>
        public Presenter(TView view)
        {
            View = view;
        }

        /// <summary>
        /// Gets or sets view.
        /// </summary>
        public TView View { get; protected set; }
    }
}
