using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace usb_hid.viewmodel
{
    public class ControlBarViewModel:BaseViewModel
    {
        #region command
        public ICommand CloseWindowsCommand { get; set; }
        public ICommand MaximizeWindowsCommand { get; set; }
        public ICommand MinimizeWindowsCommand { get; set; }
        public ICommand MouseMoveWindowsCommand { get; set; }
        #endregion
        public ControlBarViewModel()
        {
            CloseWindowsCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; },
                (p) =>
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.Close();
                    }
                });
            //
            MaximizeWindowsCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; },
                (p) => {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        if (w.WindowState != WindowState.Maximized)
                        {
                            w.WindowState = WindowState.Maximized;
                        }
                        else
                        {
                            w.WindowState = WindowState.Normal;
                        }
                        
                    }
                });
            //
            MinimizeWindowsCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; },
                (p) => {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        if (w.WindowState != WindowState.Minimized)
                        {
                            w.WindowState = WindowState.Minimized;
                        }
                        else
                        {
                            w.WindowState = WindowState.Maximized;
                        }
                    }
                });

            MouseMoveWindowsCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; },
                (p) => {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.DragMove();

                    }
                });




        }
        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            while (parent.Parent !=  null)
            {

                if (parent.Parent != null)
                {
                    parent = parent.Parent as FrameworkElement;
                }

            }
            return parent;
            
        }



    }
}
