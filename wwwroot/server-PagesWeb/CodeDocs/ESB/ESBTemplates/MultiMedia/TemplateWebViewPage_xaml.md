﻿[Zpět](../../../)   

```xml   
<UserControl
    x:Class="EasyITSystemCenter.Pages.TemplateWebViewPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:Controls="http://metro.mahapps.com/winfx/xaml/controls"
    xmlns:behaviors="clr-namespace:EasyITSystemCenter.Pages"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:dragablz="clr-namespace:Dragablz;assembly=Dragablz"
    xmlns:globalization="clr-namespace:System.Globalization;assembly=mscorlib"
    xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
    xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
    xmlns:local="clr-namespace:EasyITSystemCenter"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:sys="clr-namespace:System;assembly=mscorlib"
    xmlns:wpf="clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf"
    xmlns:xctk="http://schemas.xceed.com/wpf/xaml/toolkit"
    Name="Setting"
    HorizontalAlignment="Stretch"
    VerticalAlignment="Stretch"
    d:DesignHeight="500"
    d:DesignWidth="600"
    Tag="Setting"
    mc:Ignorable="d">

    <!--  Standartized Full Page Grid  -->
    <Grid
        Margin="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
        Background="{DynamicResource AccentColorBrush}">

        <Grid x:Name="ListView" Visibility="Visible">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                <RowDefinition Height="*" />
            </Grid.RowDefinitions>

            <wpf:ChromiumWebBrowser
                x:Name="webViewer"
                Grid.Row="0" Grid.Column="0"
                HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
                IsEnabled="True" />
        </Grid>
    </Grid>
</UserControl>
```
