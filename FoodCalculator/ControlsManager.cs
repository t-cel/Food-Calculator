using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace FoodCalculator
{
    public class ControlsManager
    {
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static void SetColorsInForm(Form form)
        {
            SettingsManager.Settings colorInfo = SettingsManager.GetInstance.settings;

            form.BackColor = colorInfo.BackgroundColor;
            form.ForeColor = colorInfo.BackgroundTextColor;

            var allButtons = GetAll(form, typeof(Button));
            var allPanels = GetAll(form, typeof(Panel));

            foreach(var b in allButtons)
            {
                b.BackColor = colorInfo.ButtonsColor;
                b.ForeColor = colorInfo.ButtonsTextColor;
            }

            foreach(var p in allPanels)
            {
                p.BackColor = colorInfo.PanelsBackgorundColor;
                p.ForeColor = colorInfo.PanelsTextColor; //not checked
            }
        }
    }
}
