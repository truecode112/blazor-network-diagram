#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/checkbox",
                FileName = "CheckBox.razor",
                HeaderText = "Blazor Checkbox Component Example - Default Functionalities"
            },
           new Sample
            {
                Name = "Radio Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/radio-button",
                FileName = "RadioButton.razor",
                HeaderText = "Blazor Radio Button Component Example - Default Functionalities"
            },
           new Sample
            {
                Name = "Dropdown Menu",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/dropdown-menu",
                FileName = "DropDownButton.razor",
                HeaderText = "Blazor Dropdown Menu Component Example - Default Functionalities",
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/split-button",
                FileName = "SplitButton.razor",
                HeaderText = "Blazor Split Button Component Example - Default Functionalities"
            },
           new Sample
            {
                Name = "Toggle Switch Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/toggle-switch-button",
                FileName = "Switch.razor",
                HeaderText = "Blazor Toggle Switch Button Component Example - Default Functionalities"
            },
           new Sample
            {
                Name = "Progress Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/progress-button",
                FileName = "ProgressButton.razor",
                Type = SampleType.None,
                HeaderText = "Blazor Progress Button Component Example - Default Functionalities"
            },
           new Sample
           {
               Name = "Button Group",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/button-group",
               FileName = "ButtonGroup.razor",
               HeaderText = "Blazor Button Group Component Example - Default Functionalities"
           },
            new Sample
           {
               Name = "Keyboard Navigation",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/keyboard-navigation",
               FileName = "KeyboardNavigation.razor",
           }
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/api",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Events",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/events",
                FileName = "Events.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                Type = SampleType.None
            }

        };
		public List<Sample> FAB { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/overview",
                FileName = "Overview.razor",
                NotificationDescription = new string[] {
                    "Showcases the usage of the Floating Action Button (FAB) to add new record in DataGrid."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[] {
                    "Showcase usage of IconCss, CssClass, Content and Disabled properties in FAB."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Position",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/position",
                FileName = "Position.razor",
                NotificationDescription = new string[] {
                    @"Demonstrate the different positions of the Floating Action Button on the target."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/styles",
                FileName = "Styles.razor",
                NotificationDescription = new string[] {
                    @"Showcase the supported predefined styles in FAB."
                },
                Type = SampleType.None
            }
        };
		public List<Sample> SpeedDial { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/defaultfunctionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[] {
                    @"A demo for Speed Dial to display a multiple action items on click.",
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Position (Linear)",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/position",
                FileName = "Position.razor",
                NotificationDescription = new string[] {
                    @"Demonstrates the different positions of the Speed Dial in the target."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Radial Menu",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/radialmenu",
                FileName = "RadialMenu.razor",
                NotificationDescription = new string[] {
                    @"Showcases the radial menu mode of the Speed Dial."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/styles",
                FileName = "Styles.razor",
                NotificationDescription = new string[] {
                    @"Demonstrates the appearance customization of the Speed Dial action items."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/template",
                FileName = "Template.razor",
                NotificationDescription = new string[] {
                    @"Showcases the usage of action items and speed dial popup using templates."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Modal",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/modal",
                FileName = "Modal.razor",
                NotificationDescription = new string[] {
                    "Demonstrates the modal popup of a speed dial",
                },
                Type = SampleType.None
            }
        };
    }
}
