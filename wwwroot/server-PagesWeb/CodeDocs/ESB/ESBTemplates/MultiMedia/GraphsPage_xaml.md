﻿[Zpět](../../../)   

```xml   
<UserControl
    x:Class="EasyITSystemCenter.Pages.GraphsPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:Controls="http://metro.mahapps.com/winfx/xaml/controls"
    xmlns:bh="http://schemas.microsoft.com/xaml/behaviors"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
    xmlns:local="clr-namespace:EasyITSystemCenter.Pages"
    xmlns:lvc="clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:xctk="http://schemas.xceed.com/wpf/xaml/toolkit"
    Name="Settings"
    HorizontalAlignment="Stretch"
    VerticalAlignment="Stretch"
    d:DesignHeight="500"
    d:DesignWidth="600"
    Foreground="White"
    Tag="Settings"
    mc:Ignorable="d">

    <UserControl.Resources>
        <BooleanToVisibilityConverter x:Key="bvc" />
    </UserControl.Resources>
    <Grid
        Margin="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
        <Grid.Background>
            <RadialGradientBrush>
                <GradientStop Offset="0" Color="#FF313131" />
                <GradientStop Offset="1" Color="#FF181818" />
            </RadialGradientBrush>
        </Grid.Background>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <ScrollViewer
            Grid.Row="0" Grid.Column="0"
            Width="{Binding Path=ActualWidth, ElementName=Settings}"
            Height="{Binding Path=ActualHeight, ElementName=Settings}"
            HorizontalAlignment="Stretch" VerticalAlignment="Stretch" ScrollViewer.HorizontalScrollBarVisibility="Auto" ScrollViewer.VerticalScrollBarVisibility="Auto">
            <xctk:SwitchPanel
                Width="1200" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" ScrollViewer.HorizontalScrollBarVisibility="Auto" ScrollViewer.VerticalScrollBarVisibility="Auto">

                <DockPanel
                    Width="500" Height="500" Margin="20">
                    <lvc:CartesianChart LegendLocation="Right" Series="{Binding SeriesCollection}">
                        <lvc:CartesianChart.AxisY>
                            <lvc:Axis Title="Sales" LabelFormatter="{Binding YFormatter}" />
                        </lvc:CartesianChart.AxisY>
                        <lvc:CartesianChart.AxisX>
                            <lvc:Axis Title="Month" Labels="{Binding Labels}" />
                        </lvc:CartesianChart.AxisX>
                    </lvc:CartesianChart>
                </DockPanel>

                <DockPanel
                    Width="500" Height="500" Margin="10">
                    <lvc:PieChart
                        DataClick="Chart_OnDataClick"
                        DataTooltip="{x:Null}"
                        Hoverable="False" LegendLocation="Bottom">
                        <lvc:PieChart.Series>
                            <lvc:PieSeries
                                Title="Maria" DataLabels="True"
                                LabelPoint="{Binding PointLabel}"
                                Values="3" />
                            <lvc:PieSeries
                                Title="Charles" DataLabels="True"
                                LabelPoint="{Binding PointLabel}"
                                Values="4" />
                            <lvc:PieSeries
                                Title="Frida" DataLabels="True"
                                LabelPoint="{Binding PointLabel}"
                                Values="6" />
                            <lvc:PieSeries
                                Title="Frederic" DataLabels="True"
                                LabelPoint="{Binding PointLabel}"
                                Values="2" />
                        </lvc:PieChart.Series>
                    </lvc:PieChart>
                </DockPanel>

                <DockPanel
                    Width="500" Height="500" Margin="10">
                    <Button Margin="10" Click="ChangeValueOnClick">Update</Button>
                    <lvc:AngularGauge
                        Grid.Row="1" FontSize="16" FontWeight="Bold" Foreground="White" FromValue="50"
                        LabelsStep="50" SectionsInnerRadius=".5" TicksForeground="White" TicksStep="25" ToValue="250"
                        Wedge="300"
                        Value="{Binding Value}">
                        <lvc:AngularGauge.Sections>
                            <lvc:AngularSection
                                Fill="#F8A725" FromValue="50" ToValue="200" />
                            <lvc:AngularSection
                                Fill="#FF3939" FromValue="200" ToValue="250" />
                        </lvc:AngularGauge.Sections>
                    </lvc:AngularGauge>
                </DockPanel>

                <DockPanel
                    Width="500" Height="500" Margin="10">
                    <lvc:CartesianChart>
                        <lvc:CartesianChart.Series>
                            <lvc:LineSeries
                                PointGeometrySize="18" StrokeThickness="4"
                                Values="{Binding SeriesValues}" />
                        </lvc:CartesianChart.Series>
                    </lvc:CartesianChart>
                </DockPanel>

                <DockPanel
                    Width="500" Height="500" Margin="10">
                    <StackPanel Orientation="Horizontal">
                        <CheckBox IsChecked="{Binding MariaSeriesVisibility}">
                            Maria Series
                        </CheckBox>
                        <CheckBox IsChecked="{Binding CharlesSeriesVisibility}">
                            Charles Series
                        </CheckBox>
                        <CheckBox IsChecked="{Binding JohnSeriesVisibility}">
                            John Series
                        </CheckBox>
                    </StackPanel>
                    <lvc:CartesianChart Hoverable="False">
                        <lvc:CartesianChart.Series>
                            <lvc:ColumnSeries
                                Title="Maria" MaxWidth="1000" ColumnPadding="0" Values="4,7,2,9,3"
                                Visibility="{Binding MariaSeriesVisibility, Converter={StaticResource bvc}}" />
                            <lvc:ColumnSeries
                                Title="Charles" MaxWidth="1000" ColumnPadding="0" Values="6,2,6,3,8"
                                Visibility="{Binding CharlesSeriesVisibility, Converter={StaticResource bvc}}" />
                            <lvc:ColumnSeries
                                Title="John" MaxWidth="1000" ColumnPadding="0" Values="7,2,8,3,9"
                                Visibility="{Binding JohnSeriesVisibility, Converter={StaticResource bvc}}" />
                        </lvc:CartesianChart.Series>
                        <lvc:CartesianChart.AxisX>
                            <lvc:Axis Labels="January, February, March, April, May">
                                <lvc:Axis.Separator>
                                    <lvc:Separator Step="1" />
                                </lvc:Axis.Separator>
                            </lvc:Axis>
                        </lvc:CartesianChart.AxisX>
                    </lvc:CartesianChart>
                </DockPanel>
            </xctk:SwitchPanel>
        </ScrollViewer>
    </Grid>
</UserControl>    

```   
