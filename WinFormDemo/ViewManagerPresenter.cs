using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    /// <summary>
    ///     Responsible for handling the viewManager onClick methods. Basically handles
    ///     which user controller is being shown.
    /// </summary>
    class ViewManagerPresenter
    {
        private readonly IViewManagerView m_ViewManagerView;

        public ViewManagerPresenter(IViewManagerView viewManagerView)
        {
            this.m_ViewManagerView = viewManagerView;
        }

        public void ChangeState(string state)
        {
            if (state == "Basic")
            {
                m_ViewManagerView.bcCalculator.ShowUserController();
            } else if (state == "Scientific")
            {
                m_ViewManagerView.bcCalculator.HideUserController();
                // m_ViewManagerView.scCalculator.Show();
            } else
            {
                m_ViewManagerView.bcCalculator.HideUserController();
                // m_ViewManagerView.History.Show();
            }
        }

    }
}
