﻿[Zpět](../../../)   

```xml   
<UserControl
    x:Class="EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:Controls="http://metro.mahapps.com/winfx/xaml/controls"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:local="clr-namespace:EasyITSystemCenter.Pages"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:xctk="http://schemas.xceed.com/wpf/xaml/toolkit"
    Name="Form"
    HorizontalAlignment="Stretch"
    VerticalAlignment="Stretch"
    d:DesignHeight="500"
    d:DesignWidth="600"
    Tag="Form"
    mc:Ignorable="d">

    <Grid
        Margin="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch"
        Background="{DynamicResource AccentColorBrush}">
        <Grid x:Name="ListView" Visibility="Visible">
            <DataGrid
                x:Name="DgListView"
                Width="{Binding Path=ActualWidth, ElementName=Form}"
                Height="{Binding Path=ActualHeight, ElementName=Form}"
                HorizontalAlignment="Left" VerticalAlignment="Top"
                AutoGenerateColumns="True" AutoGeneratedColumns="DgListView_Translate" IsReadOnly="True" MouseDoubleClick="DgListView_MouseDoubleClick" SelectionChanged="DgListView_SelectionChanged" SelectionMode="Single" />
        </Grid>

        <Grid
            x:Name="ListForm"
            Background="{DynamicResource WhiteBrush}"
            Visibility="Visible">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="300" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto" />
                <RowDefinition Height="Auto" />
                <RowDefinition Height="80" />
                <RowDefinition Height="Auto" />
                <RowDefinition Height="*" />
                <RowDefinition Height="110" />
            </Grid.RowDefinitions>

            <Label
                x:Name="lbl_id"
                Grid.Row="0" Grid.Column="0"
                HorizontalAlignment="Right" HorizontalContentAlignment="Right" />
            <Controls:NumericUpDown
                x:Name="txt_id"
                Grid.Row="0" Grid.Column="1"
                Margin="0,2,0,2" HorizontalContentAlignment="Left"
                Controls:TextBoxHelper.ClearTextButton="False" Controls:TextBoxHelper.Watermark="" HideUpDownButtons="True" IsEnabled="False" ToolTip="This unique identificator is read only value which is filled automatically by system" />

            <Label
                x:Name="lbl_systemName"
                Grid.Row="1" Grid.Column="0"
                HorizontalAlignment="Right" HorizontalContentAlignment="Right" />
            <TextBox
                x:Name="txt_systemName"
                Grid.Row="1" Grid.Column="1"
                Margin="0,2,0,2"
                Controls:TextBoxHelper.ClearTextButton="true" Controls:TextBoxHelper.IsWaitingForData="True" Controls:TextBoxHelper.Watermark="" />

            <Label
                x:Name="lbl_description"
                Grid.Row="2" Grid.Column="0"
                HorizontalAlignment="Right" HorizontalContentAlignment="Right" />
            <TextBox
                x:Name="txt_description"
                Grid.Row="2" Grid.Column="1"
                Margin="0,2,0,2"
                Controls:TextBoxHelper.ClearTextButton="True" Controls:TextBoxHelper.Watermark="" AcceptsReturn="True" TextWrapping="Wrap" VerticalScrollBarVisibility="Visible" />

            <Label
                x:Name="lbl_active"
                Grid.Row="3" Grid.Column="0"
                HorizontalAlignment="Right" HorizontalContentAlignment="Right" />
            <CheckBox
                x:Name="chb_active"
                Grid.Row="3" Grid.Column="1"
                VerticalAlignment="Center" />

            <Button
                Name="btn_save"
                Grid.Row="5" Grid.Column="0"
                Width="200" Height="40"
                Margin="44,21,0,44" HorizontalAlignment="Left" VerticalAlignment="Bottom"
                Click="BtnSave_Click"
                Style="{DynamicResource AccentedSquareButtonStyle}" />
            <Button
                Name="btn_cancel"
                Grid.Row="5" Grid.Column="1"
                Width="200" Height="40"
                Margin="44,21,44,44" HorizontalAlignment="Right" VerticalAlignment="Bottom"
                Click="BtnCancel_Click"
                Style="{DynamicResource AccentedSquareButtonStyle}" />
        </Grid>
    </Grid>
</UserControl>
```
