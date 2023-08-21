# How-to-select-multiple-chips-from-the-.NET-MAUI-SfChipGroup

This article demonstrates how to enable the selection of multiple chips within a .NET MAUI ChipGroup (SfChipGroup) control. By setting the ChipType to Filter and utilizing visual states, you can select multiple chips and change the selected chip’s color. Additionally, learn how to programmatically select chips using the SelectedItem property

Consider a scenario where you need to allow users to select multiple languages from a provided list.

Steps:

Step 1: Set ChipType to Filter for Multiple Selection

To enable the selection of multiple chips in a group, set the ChipType property of the SfChipGroup to “Filter”. This configuration allows users to choose more than one chip within the group.

XAML

<chip:SfChipGroup ChipType="Filter">
        ...
</chip:SfChipGroup>

Step 2: Add Visual States for Selected Chip Color

Utilize visual states to dynamically change the selected chip’s color when chips are clicked. Customize the ChipBackground and ChipTextColor properties for the selected and unselected states.

XAML

    <chip:SfChipGroup ChipType="Filter"
                      ItemsSource="{Binding Languages}"
                      SelectionIndicatorColor="White"
                      SelectedItem="{Binding SelectedItems}"
                      DisplayMemberPath="Name">
            <VisualStateManager.VisualStateGroups>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal">
                        <VisualState.Setters>
                            <Setter Property="ChipTextColor" Value="Black" />
                            <Setter Property="ChipBackground" Value="LightGray" />
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Selected">
                        <VisualState.Setters>
                            <Setter Property="ChipTextColor" Value="White" />
                            <Setter Property="ChipBackground" Value="Red" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateManager.VisualStateGroups>
     </chip:SfChipGroup>
Step 3: Programmatically Select Chips

In your ViewModel class, populate the required list of chip items and predefined selected items.

C#

    public class ViewModel
    {

        public ObservableCollection<Language> Languages { get; set; }

        public ObservableCollection<Language> SelectedItems { get; set; }

        public ViewModel()
        {
            this.Languages = new ObservableCollection<Language>();

            Languages.Add(new Language() { Name = "C#" });
            Languages.Add(new Language() { Name = "Python" });
            Languages.Add(new Language() { Name = "Java" });
            Languages.Add(new Language() { Name = "Js" });

            SelectedItems = new ObservableCollection<Language>() { Languages[0], Languages[1] };
        }
        
    }
    
