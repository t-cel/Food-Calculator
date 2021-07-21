using System;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            AutoScroll = true;

            ControlsManager.SetColorsInForm(this);
            RefreshColors();
        }

        private void RefreshColors()
        {
            bgColorBox.BackColor = SettingsManager.GetInstance.settings.BackgroundColor;
            buttonsColorBox.BackColor = SettingsManager.GetInstance.settings.ButtonsColor;

            bgTextCol.BackColor = SettingsManager.GetInstance.settings.BackgroundTextColor;
            buttonsTextCol.BackColor = SettingsManager.GetInstance.settings.ButtonsTextColor;

            panelsTextCol.BackColor = SettingsManager.GetInstance.settings.PanelsTextColor;
            panelsBgCol.BackColor = SettingsManager.GetInstance.settings.PanelsBackgorundColor;

            productsColBox.BackColor = SettingsManager.GetInstance.settings.ProductColumnColor;
            productsTextCol.BackColor = SettingsManager.GetInstance.settings.ProductTextColor;

            mealsColBox.BackColor = SettingsManager.GetInstance.settings.MealColumnColor;
            mealsTextCol.BackColor = SettingsManager.GetInstance.settings.MealTextColor;

            sumColumnCol.BackColor = SettingsManager.GetInstance.settings.SumColumnColor;
            sumColText.BackColor = SettingsManager.GetInstance.settings.SumColumnTextColor;

            wholeSumCol.BackColor = SettingsManager.GetInstance.settings.WholeSumColumnColor;
            wholeSumColText.BackColor = SettingsManager.GetInstance.settings.WholeSumColumnTextColor;

            autosaveCheckbox.Checked = SettingsManager.GetInstance.settings.Autosave;
        }

        private void SetColors(SettingsManager.ColorType colorType)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.Color != null)
                {
                    var colorInfo = SettingsManager.GetInstance.settings;
                    switch (colorType)
                    {
                        case SettingsManager.ColorType.Background:
                            colorInfo.BackgroundColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.BackgroundText:
                            colorInfo.BackgroundTextColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.Buttons:
                            colorInfo.ButtonsColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.ButtonsText:
                            colorInfo.ButtonsTextColor = dialog.Color;                        
                            break;
                        case SettingsManager.ColorType.Panels:
                            colorInfo.PanelsBackgorundColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.PanelsText:
                            colorInfo.PanelsTextColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.MealColumns:
                            colorInfo.MealColumnColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.MealColumnsText:
                            colorInfo.MealTextColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.ProductColumns:
                            colorInfo.ProductColumnColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.ProductColumnsText:
                            colorInfo.ProductTextColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.SumColumns:
                            colorInfo.SumColumnColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.SumColumnsText:
                            colorInfo.SumColumnTextColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.WholeSumColumns:
                            colorInfo.WholeSumColumnColor = dialog.Color;
                            break;
                        case SettingsManager.ColorType.WholeSumColumnsText:
                            colorInfo.WholeSumColumnTextColor = dialog.Color;
                            break;
                    }
                }
                SettingsManager.Changed = true;
                RefreshColors();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsManager.GetInstance.SaveSettings(); //save changes

            if (SettingsManager.Changed) //colors were changed, restart application
            {
                DialogResult result = MessageBox.Show("The program must be restarted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult saveResult = MessageBox.Show("Save changes to the database?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(saveResult == DialogResult.Yes)
                {
                    DatabaseSerializer.Serialize(DatabaseSerializer.defaultPath);
                }

                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("The settings have been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

        private void bgColorButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.Background);
        }

        private void buttonsColorButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.Buttons);
        }

        private void productsColButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.ProductColumns);
        }

        private void mealsColButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.MealColumns);
        }

        private void panelsBgButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.Panels);
        }

        private void bgTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.BackgroundText);
        }

        private void buttonsTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.ButtonsText);
        }

        private void panelsTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.PanelsText);
        }

        private void productsTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.ProductColumnsText);
        }

        private void mealsTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.MealColumnsText);
        }

        private void sumColButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.SumColumns);
        }

        private void wholeSumColButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.WholeSumColumns);
        }

        private void sumColTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.SumColumnsText);
        }

        private void wholeSumColTextButton_Click(object sender, EventArgs e)
        {
            SetColors(SettingsManager.ColorType.WholeSumColumnsText);
        }

        private void autosaveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.GetInstance.settings.Autosave = autosaveCheckbox.Checked;
        }

    }
}
