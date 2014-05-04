﻿using System.ComponentModel;
using System.Configuration;
using CoolFishNS.Utilities;

namespace CoolFishNS.Properties
{
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings
    {
        public Settings()
        {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            SettingChanging += SettingChangingEventHandler;
            //
            SettingsSaving += SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
            Logging.Log("Setting Changed. SettingName: " + e.SettingName + " NewValue: " + e.NewValue + " OldValue: " + Default[e.SettingName]);
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
            Logging.Write("Settings Saved");
        }
    }
}