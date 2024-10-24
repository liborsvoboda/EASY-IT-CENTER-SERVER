[Zpět](../)   

```xml   
<Controls:MetroWindow
    x:Class="EasyITSystemCenter.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:Controls="clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro"
    xmlns:TouchKeyboard="clr-namespace:EASYTools.Controls;assembly=EASYTools.TouchKeyboard"
    xmlns:behaviors="clr-namespace:EasyITSystemCenter.ProgramaticXamlBehaviors"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:dockablz="clr-namespace:Dragablz.Dockablz;assembly=Dragablz"
    xmlns:dragablz="clr-namespace:Dragablz;assembly=Dragablz"
    xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
    xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
    xmlns:local="clr-namespace:EasyITSystemCenter"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:xctk="http://schemas.xceed.com/wpf/xaml/toolkit"
    x:Name="XamlMainWindow"
    MinWidth="1024"
    MinHeight="768"
    d:DesignHeight="768"
    d:DesignWidth="1024"
    AllowDrop="False"
    AllowsTransparency="False"
    BorderThickness="1"
    GlowBrush="{DynamicResource AccentColorBrush}"
    Icon="Data\Images\lama.ico"
    NonActiveGlowBrush="#CDFF0000"
    ResizeMode="CanResizeWithGrip"
    SaveWindowPosition="True"
    ShowIconOnTitleBar="True"
    ShowSystemMenuOnRightClick="True"
    ShowTitleBar="True"
    WindowStartupLocation="CenterScreen"
    WindowTransitionsEnabled="True"
    mc:Ignorable="d">
    <!--
        GlowBrush="{DynamicResource GlyphBrush}"
        RenderOptions.ClearTypeHint="Enabled"
        TextOptions.TextFormattingMode="Display"
    -->
    <!--<Controls:MetroWindow.LeftWindowCommands>
        <Controls:WindowCommands>
            <Button x:Name="btn_showOnlineLogger" Click="BtnShowLoggerClick" Style="{StaticResource MahAppsToolWindowButtonStyle}">
                <iconPacks:FontAwesome
                    Width="22" Height="22" Kind="LifeRingSolid" />
            </Button>
        </Controls:WindowCommands>
    </Controls:MetroWindow.LeftWindowCommands>-->

    <Controls:MetroWindow.RightWindowCommands>
        <Controls:WindowCommands>
            <Menu>
                <MenuItem
                    x:Name="mi_appearance"
                    Width="60"
                    FontWeight="Normal"
                    ItemContainerStyle="{StaticResource AppThemeMenuItemStyle}"
                    ItemsSource="{Binding AppThemes, Mode=OneWay}" />
                <MenuItem
                    x:Name="mi_color"
                    Width="50"
                    FontWeight="Normal" Header=""
                    ItemContainerStyle="{StaticResource AccentColorMenuItemStyle}"
                    ItemsSource="{Binding AccentColors, Mode=OneWay}" />
            </Menu>
            <Button
                x:Name="btn_about"
                Click="Btn_about_click" Cursor="Hand" ToolTip="Version Info">
                <iconPacks:PackIconModern
                    Width="22" Height="22"
                    Kind="InformationCircle" />
            </Button>
            <Button
                x:Name="btn_launchHelp"
                Click="Btn_LaunchHelp_Click" Cursor="Hand" ToolTip="Dokumentace Struktury Systému">
                <iconPacks:Modern
                    Width="22" Height="22"
                    Kind="BookPerspectiveHelp" />
            </Button>
            <Button
                x:Name="btn_showModulePanel"
                Click="Btn_ShowModulePanel_Click" Cursor="Hand" IsEnabled="False" ToolTip="Zobrazit panel s Moduly">
                <iconPacks:Material
                    Width="22" Height="22"
                    Kind="DeveloperBoard" />
            </Button>
        </Controls:WindowCommands>
    </Controls:MetroWindow.RightWindowCommands>

    <!--application Icon from iconPack not custom
        <Controls:MetroWindow.IconTemplate>
        <DataTemplate>
            <iconPacks:PackIconMaterial Kind="EyeSettings" Foreground="{DynamicResource IdealForegroundColorBrush}"
                                      Margin="4" Width="{TemplateBinding Width}" Height="{TemplateBinding Height}" />
        </DataTemplate>
    </Controls:MetroWindow.IconTemplate>-->

    <Controls:MetroWindow.IconTemplate>
        <DataTemplate>
            <Grid
                Width="{TemplateBinding Width}"
                Height="{TemplateBinding Height}"
                Margin="4"
                Background="Transparent" RenderOptions.BitmapScalingMode="HighQuality" RenderOptions.EdgeMode="Aliased">
                <Image Source="Data\Images\lama.ico" />
            </Grid>
        </DataTemplate>
    </Controls:MetroWindow.IconTemplate>

    <Controls:MetroWindow.Flyouts>
        <Controls:FlyoutsControl>
            <Controls:Flyout
                x:Name="SystemModulePanel"
                Margin="0,30,0,0" 
                AreAnimationsEnabled="True" CloseButtonVisibility="Collapsed" Header="Apps" Position="Top" Theme="Dark" TitleVisibility="Collapsed">
                <Canvas
                    x:Name="SystemModuleCanvas"
                    Height="130"
                    HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
                    <ScrollViewer
                        Width="{Binding ElementName=SystemModuleCanvas, Path=ActualWidth}"
                        Height="{Binding ElementName=SystemModuleCanvas, Path=ActualHeight}"
                        HorizontalAlignment="Stretch" VerticalAlignment="Stretch" HorizontalContentAlignment="Center" VerticalContentAlignment="Top"
                        Controls:ScrollViewerHelper.IsHorizontalScrollWheelEnabled="True" HorizontalScrollBarVisibility="Auto" ScrollViewer.CanContentScroll="True" VerticalScrollBarVisibility="Disabled">

                        <TabControl
                            x:Name="systemModuleList"
                            Margin="5,0,0,0" Padding="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" HorizontalContentAlignment="Left" VerticalContentAlignment="Top"
                            Background="Transparent" FontSize="8" TabStripPlacement="Left" />
                    </ScrollViewer>
                </Canvas>
            </Controls:Flyout>

            <Controls:Flyout
                x:Name="OnlineLogger"
                Height="200"
                Margin="0,0,0,40"
                AllowFocusElement="True" AnimateOpacity="True" AreAnimationsEnabled="True" CloseButtonIsCancel="True" CloseButtonVisibility="Visible" Header="System Logger" Position="Bottom"
                Theme="Inverse">
                <Canvas
                    x:Name="FlyoutCanvas"
                    Height="200"
                    HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
                    Background="Red">
                    <TextBox
                        x:Name="rt_SystemLogger"
                        Canvas.Left="0" Canvas.Top="0"
                        Width="{Binding ActualWidth, ElementName=FlyoutCanvas}"
                        Height="{Binding ActualHeight, ElementName=FlyoutCanvas}"
                        HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
                        Background="Black" Foreground="White" IsReadOnlyCaretVisible="True" MaxLength="1000000" ScrollViewer.VerticalScrollBarVisibility="Auto" TextWrapping="Wrap" />
                    <Controls:ToggleSwitch
                        Canvas.Top="0" Canvas.Right="10"
                        HorizontalAlignment="Right" VerticalAlignment="Top"
                        Foreground="OrangeRed"
                        IsChecked="{Binding Path=(local:MainWindow.ServerLoggerSource), Mode=TwoWay}"
                        IsCheckedChanged="SystemLoggerSourceChanged_Click" OffLabel="System Logger" OnLabel="Server Logger" />
                </Canvas>
            </Controls:Flyout>
        </Controls:FlyoutsControl>
    </Controls:MetroWindow.Flyouts>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>

        <ItemsControl
            Grid.Row="0"
            Height="40"
            Margin="0" VerticalAlignment="Stretch"
            BorderThickness="0" Focusable="False">
            <ItemsControl.Template>
                <ControlTemplate TargetType="ItemsControl">
                    <Border BorderBrush="Transparent" BorderThickness="1">
                        <ItemsPresenter />
                    </Border>
                </ControlTemplate>
            </ItemsControl.Template>
            <ItemsControl.ItemsPanel>
                <ItemsPanelTemplate>
                    <DockPanel HorizontalAlignment="Stretch" VerticalAlignment="Center" />
                </ItemsPanelTemplate>
            </ItemsControl.ItemsPanel>

            <DockPanel
                x:Name="verticalMenu"
                Width="120" Height="40"
                Margin="0" HorizontalAlignment="Left"
                Visibility="Visible">
                <ToolBar
                    x:Name="tb_verticalSystemMenu"
                    Width="120" Height="34"
                    Margin="0" Padding="0" HorizontalAlignment="Left"
                    ToolBarTray.IsLocked="True">
                    <TreeViewItem
                        x:Name="ClientSettingsPage"
                        Width="280"
                        Margin="0" HorizontalAlignment="Stretch"
                        Cursor="Hand" FontSize="16" PreviewMouseDown="Menu_Selected" />
                </ToolBar>
            </DockPanel>

            <DockPanel
                x:Name="gridMenu"
                Width="620" Height="40"
                Margin="10,0,0,0" HorizontalAlignment="Left">
                <MenuItem
                    x:Name="mi_reload"
                    Width="130" Height="34"
                    HorizontalAlignment="Left"
                    Click="Menu_action_Click" Cursor="Hand"
                    IsEnabled="{Binding Path=(local:MainWindow.DgRefresh)}" />
                <MenuItem
                    x:Name="mi_new"
                    Width="120" Height="34"
                    HorizontalAlignment="Left"
                    Click="Menu_action_Click" Cursor="Hand"
                    IsEnabled="{Binding Path=(local:MainWindow.DataGridSelected)}" />
                <MenuItem
                    x:Name="mi_edit"
                    Width="130" Height="34"
                    HorizontalAlignment="Left"
                    Click="Menu_action_Click" Cursor="Hand"
                    IsEnabled="{Binding Path=(local:MainWindow.DataGridSelectedIdListIndicator)}" />
                <MenuItem
                    x:Name="mi_copy"
                    Width="120" Height="34"
                    HorizontalAlignment="Left"
                    Click="Menu_action_Click" Cursor="Hand"
                    IsEnabled="{Binding Path=(local:MainWindow.DataGridSelectedIdListIndicator)}" />
                <MenuItem
                    x:Name="mi_delete"
                    Width="120" Height="34"
                    HorizontalAlignment="Left"
                    Click="Menu_action_Click" Cursor="Hand"
                    IsEnabled="{Binding Path=(local:MainWindow.DataGridSelectedIdListIndicator)}" />
            </DockPanel>

            <DockPanel
                x:Name="rightMenu"
                Width="260" Height="40"
                Margin="0,0,0,0" HorizontalAlignment="Right">
                <ComboBox
                    x:Name="cb_filter"
                    Width="23" Height="34"
                    Margin="0" Padding="-13,-1,0,0" HorizontalAlignment="Right"
                    Cursor="Hand" DropDownClosed="CbFilterDropDownClosed" FontSize="20"
                    IsEnabled="{Binding Path=(local:MainWindow.DgRefresh)}">
                    <WrapPanel x:Name="filter_Menu" Width="230">
                        <Button
                            x:Name="mi_plus"
                            Width="40" Height="34"
                            Margin="0" Padding="0,0,0,5" HorizontalAlignment="Right"
                            Click="Mi_filter_Click" Content="+" Cursor="Hand" FontSize="20" />
                        <Button
                            x:Name="mi_open"
                            Width="40" Height="34"
                            Margin="0" Padding="0,0,0,5" HorizontalAlignment="Right"
                            Click="Mi_filter_Click" Content="(" Cursor="Hand" FontSize="20" />
                        <Button
                            x:Name="mi_close"
                            Width="40" Height="34"
                            Margin="0" Padding="0,0,0,5" HorizontalAlignment="Right"
                            Click="Mi_filter_Click" Content=")" Cursor="Hand" FontSize="20" />
                        <Button
                            x:Name="mi_and"
                            Width="60" Height="34"
                            Margin="0" Padding="0,0,0,5" HorizontalAlignment="Right"
                            Click="Mi_filter_Click" Content="AND" Cursor="Hand" FontSize="20" />
                        <Button
                            x:Name="mi_or"
                            Width="50" Height="34"
                            Margin="0" Padding="0,0,0,5" HorizontalAlignment="Right"
                            Click="Mi_filter_Click" Content="OR" Cursor="Hand" FontSize="20" />
                    </WrapPanel>
                </ComboBox>

                <TextBox
                    x:Name="tb_search"
                    Width="130" Height="34"
                    Margin="0,0,5,0" VerticalContentAlignment="Center"
                    Controls:TextBoxHelper.ClearTextButton="true" Controls:TextBoxHelper.Watermark="Search" behaviors:TextBoxBehavior.SelectAllTextOnFocus="True"
                    IsEnabled="{Binding Path=(local:MainWindow.DgRefresh)}"
                    MaxLength="50" SelectionChanged="Menu_action_Click" />
                <MenuItem
                    x:Name="mi_logout"
                    Width="110" Height="34"
                    Margin="0,0,0,0" Padding="0,7,0,5" HorizontalAlignment="Right"
                    Click="Mi_logout_Click" Cursor="Hand" />
            </DockPanel>
        </ItemsControl>

        <dockablz:Layout
            x:Name="mainGrid"
            Grid.Row="1"
            dragablz:DragablzItem.IsDraggingChanged="MainGrid_IsDraggingChanged"
            FloatingItemContainerStyle="{DynamicResource MahAppsToolDragablzItemStyle}"
            FloatingItemDisplayMemberPath="Content" FloatingItemHeaderMemberPath="Header">

            <dragablz:TabablzControl
                x:Name="InitialTabablzControl"
                Margin="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
                HeaderMemberPath="Header"
                ItemsSource="{Binding TabContents}"
                SelectionChanged="TabPanelOnSelectionChange">

                <!--  This Code Enable Dragging TabPanel To move Out of Application to Next New Application Instance  -->
                <dragablz:TabablzControl.InterTabController>
                    <dragablz:InterTabController InterTabClient="{Binding InterTabClient}" />
                </dragablz:TabablzControl.InterTabController>

                <dragablz:TabablzControl.ContentTemplate>
                    <DataTemplate DataType="{x:Type local:SystemStructure.SystemTabs}">
                        <ContentControl Margin="2" Content="{Binding Content}" />
                    </DataTemplate>
                </dragablz:TabablzControl.ContentTemplate>
            </dragablz:TabablzControl>
        </dockablz:Layout>
        <StatusBar Grid.Row="2">
            <StatusBarItem>
                <ComboBox
                    x:Name="cb_printReports"
                    Width="200"
                    Margin="0,0,0,0" HorizontalAlignment="Left" VerticalAlignment="Center"
                    DisplayMemberPath="SystemName" FontSize="18" SelectedValuePath="SystemName" SelectionChanged="CbPrintReportsSelected" />
            </StatusBarItem>
            <Separator Style="{DynamicResource MetroStatusBarSeparator}" />
            <StatusBarItem FontSize="14">Server Status:</StatusBarItem>
            <StatusBarItem
                x:Name="sb_serviceStatus"
                Content="{Binding Path=(local:MainWindow.ServiceStatus)}"
                FontSize="14" />

            <StatusBarItem
                x:Name="toolMenu"
                Height="30"
                Margin="0" Padding="0" HorizontalAlignment="Right">
                <WrapPanel>
                    <Label
                        x:Name="si_loggedIn"
                        Margin="0,0,0,0" Padding="0"
                        FontSize="20" Foreground="Azure" />
                    <Controls:MetroProgressBar
                        x:Name="pb_downloadStatus"
                        Width="{Binding Path=(local:MainWindow.DownloadShow)}"
                        Height="30"
                        Margin="10,0,0,0"
                        Background="{DynamicResource ControlsDisabledBrush}"
                        BorderBrush="{DynamicResource ComboBoxPopupBorderBrush}"
                        Foreground="{DynamicResource ProgressBrush}"
                        Maximum="100" Minimum="0"
                        Value="{Binding Path=(local:MainWindow.DownloadStatus)}" />

                    <Button
                        x:Name="ip_help"
                        Width="30" Height="30"
                        Margin="0" HorizontalAlignment="Right"
                        Background="#99cccc" Click="BtnShowToolTipsClick" Foreground="White" ToolTip="Show All ToolTips">
                        <iconPacks:PackIconMaterial Kind="Information" />
                    </Button>
                    <Button
                        x:Name="ip_calculator"
                        Width="30" Height="30"
                        Margin="5,0,0,0" HorizontalAlignment="Right"
                        Click="BtnCalculatorClick" ToolTip="Show Calculator">
                        <iconPacks:PackIconMaterial Kind="Calculator" />
                    </Button>
                    <Button
                        x:Name="ip_keyboard"
                        Width="30" Height="30"
                        Margin="5,0,0,0" HorizontalAlignment="Right"
                        Click="BtnKeyboardClick" ToolTip="Show Keyboard">
                        <iconPacks:PackIconMaterial Kind="Keyboard" />
                    </Button>
                    <Button
                        x:Name="ip_captureApp"
                        Width="30" Height="30"
                        Margin="5,0,0,0" HorizontalAlignment="Right"
                        Click="BtnCaptureAppClick" ToolTip="ScreenShot">
                        <iconPacks:PackIconMaterial Kind="EyePlus" />
                    </Button>
                    <Button
                        x:Name="ip_rdpServer"
                        Width="30" Height="30"
                        Margin="5,0,0,0" HorizontalAlignment="Right"
                        Click="BtnStartRdpServerClick" Foreground="Red" ToolTip="Open Support Connection">
                        <iconPacks:PackIconMaterial Kind="RemoteDesktop" />
                    </Button>
                    <Button
                        x:Name="btn_showOnlineLogger"
                        Width="0" Height="30"
                        Margin="5,0,10,0" Padding="0"
                        Background="DarkSeaGreen" Click="BtnShowLoggerClick" ToolTip="Show Local System Logger"
                        Visibility="{Binding Path=(local:MainWindow.ShowSystemLogger)}">
                        <iconPacks:FontAwesome
                            x:Name="i_onlineLoggerIcon"
                            Kind="LifeRingSolid" Spin="True" SpinAutoReverse="False" SpinDuration="6" />
                    </Button>
                </WrapPanel>
            </StatusBarItem>
        </StatusBar>

        <xctk:Calculator
            x:Name="Calc"
            Grid.Row="1" Grid.Column="0"
            Width="180"
            HorizontalAlignment="Right" VerticalAlignment="Bottom"
            Visibility="Hidden" />
        <TouchKeyboard:FloatingTouchScreenKeyboard
            x:Name="TouchKeyboard"
            Width="900" Height="400"
            AreAnimationsEnabled="True" IsOpen="False" Placement="Relative"
            PlacementTarget="{Binding ElementName=XamlMainWindow}" />

        <Controls:ProgressRing
            x:Name="pr_progressRing"
            Grid.Row="0" Grid.RowSpan="3" Grid.Column="0" Grid.ColumnSpan="2"
            Width="150" Height="150"
            Margin="0,0,0,0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
            Visibility="{Binding Path=(local:MainWindow.ProgressRing)}" />
    </Grid>
</Controls:MetroWindow>
```

