﻿[Zpět](../../../../)   

```xml   
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Style x:Key="DocumentStyle" TargetType="FlowDocument">
        <Setter Property="FontFamily" Value="Calibri" />
        <Setter Property="TextAlignment" Value="Left" />
    </Style>

    <Style x:Key="H1Style" TargetType="Paragraph">
        <Setter Property="FontSize" Value="42" />
        <Setter Property="Foreground" Value="#ff000000" />
        <Setter Property="FontWeight" Value="Light" />
    </Style>

    <Style x:Key="H2Style" TargetType="Paragraph">
        <Setter Property="FontSize" Value="20" />
        <Setter Property="Foreground" Value="#ff000000" />
        <Setter Property="FontWeight" Value="Light" />
    </Style>

    <Style x:Key="H3Style" TargetType="Paragraph">
        <Setter Property="FontSize" Value="20" />
        <Setter Property="Foreground" Value="#99000000" />
        <Setter Property="FontWeight" Value="Light" />
    </Style>

    <Style x:Key="H4Style" TargetType="Paragraph">
        <Setter Property="FontSize" Value="14" />
        <Setter Property="Foreground" Value="#99000000" />
        <Setter Property="FontWeight" Value="Light" />
    </Style>

    <Style x:Key="LinkStyle" TargetType="Hyperlink">
        <Setter Property="TextDecorations" Value="None" />
    </Style>

    <Style x:Key="ImageStyle" TargetType="Image">
        <Setter Property="RenderOptions.BitmapScalingMode" Value="NearestNeighbor" />
        <Style.Triggers>
            <Trigger Property="Tag" Value="imageright">
                <Setter Property="Margin" Value="20,0,0,0" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style x:Key="SeparatorStyle" TargetType="Separator">
        <!--<Setter Property="X2"
                  Value="{Binding ActualWidth, RelativeSource={RelativeSource AncestorType=FlowDocumentScrollViewer}}" />
          <Setter Property="Stroke"
                  Value="#99000000" />
          <Setter Property="StrokeThickness"
                  Value="2" />-->
    </Style>

    <!--
        The Table's style don't seem to support border-collapse.
        By making the ruled line width 0.5 and applying it to cell and table,
        it looks like the ruled lines are not doubled.
    -->
    <Style x:Key="TableStyle" TargetType="Table">
        <Setter Property="CellSpacing" Value="0" />
        <Setter Property="BorderThickness" Value="0.5" />
        <Setter Property="BorderBrush" Value="Gray" />
        <Style.Resources>
            <Style TargetType="TableCell">
                <Setter Property="BorderThickness" Value="0.5" />
                <Setter Property="BorderBrush" Value="Gray" />
                <Setter Property="Padding" Value="2" />
            </Style>
        </Style.Resources>
    </Style>
    <Style x:Key="TableHeaderStyle" TargetType="TableRowGroup">
        <Setter Property="FontWeight" Value="DemiBold" />
        <Setter Property="Background" Value="LightGray" />
    </Style>

    <Style TargetType="Section">
        <Style.Triggers>
            <Trigger Property="Tag" Value="Blockquote">
                <Setter Property="Padding" Value="10,5" />
                <Setter Property="BorderBrush" Value="#DEDEDE" />
                <Setter Property="BorderThickness" Value="5,0,0,0" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style TargetType="Paragraph">
        <Style.Triggers>
            <Trigger Property="Tag" Value="Heading1">
                <Setter Property="FontSize" Value="42" />
                <Setter Property="Foreground" Value="#ff000000" />
                <Setter Property="FontWeight" Value="Light" />
            </Trigger>

            <Trigger Property="Tag" Value="Heading2">
                <Setter Property="FontSize" Value="20" />
                <Setter Property="Foreground" Value="#ff000000" />
                <Setter Property="FontWeight" Value="Light" />
            </Trigger>

            <Trigger Property="Tag" Value="Heading3">
                <Setter Property="FontSize" Value="20" />
                <Setter Property="Foreground" Value="#99000000" />
                <Setter Property="FontWeight" Value="Light" />
            </Trigger>

            <Trigger Property="Tag" Value="Heading4">
                <Setter Property="FontSize" Value="14" />
                <Setter Property="Foreground" Value="#99000000" />
                <Setter Property="FontWeight" Value="Light" />
            </Trigger>

            <Trigger Property="Tag" Value="CodeBlock">
                <Setter Property="FontFamily" Value="Courier New" />
                <Setter Property="Foreground" Value="DarkBlue" />
                <Setter Property="Background" Value="#EEEEEE" />
                <Setter Property="BorderBrush" Value="#DEDEDE" />
                <Setter Property="BorderThickness" Value="0,5,0,5" />
                <Setter Property="Margin" Value="5,0,5,0" />
            </Trigger>

            <Trigger Property="Tag" Value="Note">
                <Setter Property="Margin" Value="5,0,5,0" />
                <Setter Property="Padding" Value="10,5" />
                <Setter Property="BorderBrush" Value="#DEDEDE" />
                <Setter Property="BorderThickness" Value="3,3,3,3" />
                <Setter Property="Background" Value="#FAFAFA" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style TargetType="Run">
        <Style.Triggers>
            <Trigger Property="Tag" Value="CodeSpan">
                <Setter Property="FontFamily" Value="Courier New" />
                <Setter Property="Foreground" Value="DarkBlue" />
                <Setter Property="Background" Value="#E0E0E0" />
            </Trigger>
        </Style.Triggers>
    </Style>
    <Style TargetType="Span">
        <Style.Triggers>
            <Trigger Property="Tag" Value="CodeSpan">
                <Setter Property="FontFamily" Value="Courier New" />
                <Setter Property="Foreground" Value="DarkBlue" />
                <Setter Property="Background" Value="#E0E0E0" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style TargetType="Hyperlink">
        <Setter Property="TextDecorations" Value="None" />
    </Style>

    <Style TargetType="Image">
        <Setter Property="RenderOptions.BitmapScalingMode" Value="NearestNeighbor" />
        <Style.Triggers>
            <Trigger Property="Tag" Value="imageright">
                <Setter Property="Margin" Value="20,0,0,0" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <!--
        The Table's style don't seem to support border-collapse.
        By making the ruled line width 0.5 and applying it to cell and table,
        it looks like the ruled lines are not doubled.
    -->
    <Style TargetType="Table">
        <Setter Property="CellSpacing" Value="0" />
        <Setter Property="BorderThickness" Value="0.5" />
        <Setter Property="BorderBrush" Value="Gray" />
    </Style>

    <Style TargetType="TableRowGroup">
        <Style.Triggers>
            <Trigger Property="Tag" Value="TableHeader">
                <Setter Property="FontWeight" Value="DemiBold" />
                <Setter Property="Background" Value="LightGray" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style TargetType="TableCell">
        <Setter Property="BorderThickness" Value="0.5" />
        <Setter Property="BorderBrush" Value="Gray" />
        <Setter Property="Padding" Value="2" />
        <Style.Triggers>
            <DataTrigger Binding="{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TableRow}}, Path=Tag}" Value="EvenTableRow">
                <Setter Property="Background" Value="#F5F5F5" />
            </DataTrigger>
        </Style.Triggers>
    </Style>

    <Style TargetType="BlockUIContainer">
        <Style.Triggers>
            <Trigger Property="Tag" Value="RuleSingle">
                <Setter Property="Margin" Value="0,3" />
            </Trigger>

            <Trigger Property="Tag" Value="RuleDouble">
                <Setter Property="Margin" Value="0,3" />
            </Trigger>

            <Trigger Property="Tag" Value="RuleBold">
                <Setter Property="Margin" Value="0,3" />
            </Trigger>

            <Trigger Property="Tag" Value="RuleBoldWithSingle">
                <Setter Property="Margin" Value="0,3" />
            </Trigger>
        </Style.Triggers>
    </Style>

    <Style x:Key="DocumentStyleCompact" TargetType="FlowDocument">
        <Setter Property="FontFamily" Value="Calibri" />
        <Setter Property="TextAlignment" Value="Left" />
        <Setter Property="PagePadding" Value="0" />
        <Setter Property="FontSize" Value="12" />

        <Style.Resources>
            <Style TargetType="Section">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="Blockquote">
                        <Setter Property="Padding" Value="10,5" />
                        <Setter Property="BorderBrush" Value="#DEDEDE" />
                        <Setter Property="BorderThickness" Value="5,0,0,0" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Paragraph">
                <Setter Property="Margin" Value="4,2,0,6" />

                <Style.Triggers>
                    <Trigger Property="Tag" Value="Heading1">
                        <Setter Property="Margin" Value="0,10,0,2" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="16" />
                        <Setter Property="FontWeight" Value="UltraBold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading2">
                        <Setter Property="Margin" Value="0,10,0,2" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="14" />
                        <Setter Property="FontWeight" Value="Bold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading3">
                        <Setter Property="Margin" Value="0,6,0,2" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="13" />
                        <Setter Property="FontWeight" Value="Light" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading4">
                        <Setter Property="Margin" Value="0,6,0,2" />

                        <Setter Property="Foreground" Value="#aa000000" />
                        <Setter Property="FontSize" Value="12" />
                        <Setter Property="FontWeight" Value="Light" />
                        <Setter Property="FontStyle" Value="Italic" />
                    </Trigger>

                    <Trigger Property="Tag" Value="CodeBlock">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="Foreground" Value="DarkBlue" />
                        <Setter Property="Background" Value="#EEEEEE" />
                        <Setter Property="BorderBrush" Value="#DEDEDE" />
                        <Setter Property="BorderThickness" Value="0,5,0,5" />
                        <Setter Property="Margin" Value="5,0,5,0" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Note">
                        <Setter Property="Margin" Value="5,0,5,0" />
                        <Setter Property="Padding" Value="10,5" />
                        <Setter Property="BorderBrush" Value="#DEDEDE" />
                        <Setter Property="BorderThickness" Value="3,3,3,3" />
                        <Setter Property="Background" Value="#FAFAFA" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Run">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="CodeSpan">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="Foreground" Value="DarkBlue" />
                        <Setter Property="Background" Value="#E0E0E0" />
                    </Trigger>
                </Style.Triggers>
            </Style>
            <Style TargetType="Span">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="CodeSpan">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="Foreground" Value="DarkBlue" />
                        <Setter Property="Background" Value="#E0E0E0" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Hyperlink">
                <Setter Property="TextDecorations" Value="None" />
            </Style>

            <Style TargetType="Image">
                <Setter Property="RenderOptions.BitmapScalingMode" Value="NearestNeighbor" />
                <Style.Triggers>
                    <Trigger Property="Tag" Value="imageright">
                        <Setter Property="Margin" Value="20,0,0,0" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="List">
                <Setter Property="Margin" Value="0,0,0,0" />
            </Style>

            <!--
                The Table's style don't seem to support border-collapse.
                By making the ruled line width 0.5 and applying it to cell and table,
                it looks like the ruled lines are not doubled.
            -->
            <Style TargetType="Table">
                <Setter Property="CellSpacing" Value="0" />
                <Setter Property="BorderThickness" Value="0.5" />
                <Setter Property="BorderBrush" Value="Gray" />
            </Style>

            <Style TargetType="TableRowGroup">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="TableHeader">
                        <Setter Property="FontWeight" Value="DemiBold" />
                        <Setter Property="Background" Value="LightGray" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="TableCell">
                <Setter Property="BorderThickness" Value="0.5" />
                <Setter Property="BorderBrush" Value="Gray" />
                <Setter Property="Padding" Value="1" />
                <Style.Triggers>
                    <DataTrigger Binding="{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TableRow}}, Path=Tag}" Value="EvenTableRow">
                        <Setter Property="Background" Value="#F5F5F5" />
                    </DataTrigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="BlockUIContainer">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="RuleSingle">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleDouble">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleBold">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleBoldWithSingle">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>
                </Style.Triggers>
            </Style>
        </Style.Resources>
    </Style>

    <Style x:Key="DocumentStyleGithubLike" TargetType="FlowDocument">
        <Setter Property="FontFamily" Value="Calibri" />
        <Setter Property="TextAlignment" Value="Left" />
        <Setter Property="PagePadding" Value="0" />
        <Setter Property="FontSize" Value="14" />

        <Style.Resources>
            <Style TargetType="Section">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="Blockquote">
                        <Setter Property="Padding" Value="10,5" />
                        <Setter Property="BorderBrush" Value="#DEDEDE" />
                        <Setter Property="BorderThickness" Value="5,0,0,0" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Paragraph">
                <Setter Property="Margin" Value="0,7,0,0" />

                <Style.Triggers>
                    <Trigger Property="Tag" Value="Heading1">
                        <Setter Property="Margin" Value="0,0,15,0" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="28" />
                        <Setter Property="FontWeight" Value="UltraBold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading2">
                        <Setter Property="Margin" Value="0,0,15,0" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="21" />
                        <Setter Property="FontWeight" Value="Bold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading3">
                        <Setter Property="Margin" Value="0,0,10,0" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="17.5" />
                        <Setter Property="FontWeight" Value="Bold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Heading4">
                        <Setter Property="Margin" Value="0,0,5,0" />

                        <Setter Property="Foreground" Value="#ff000000" />
                        <Setter Property="FontSize" Value="14" />
                        <Setter Property="FontWeight" Value="Bold" />
                    </Trigger>

                    <Trigger Property="Tag" Value="CodeBlock">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="FontSize" Value="11.9" />
                        <Setter Property="Background" Value="#12181F25" />
                        <Setter Property="Padding" Value="20,10" />
                    </Trigger>

                    <Trigger Property="Tag" Value="Note">
                        <Setter Property="Margin" Value="5,0,5,0" />
                        <Setter Property="Padding" Value="10,5" />
                        <Setter Property="BorderBrush" Value="#DEDEDE" />
                        <Setter Property="BorderThickness" Value="3,3,3,3" />
                        <Setter Property="Background" Value="#FAFAFA" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Run">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="CodeSpan">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="FontSize" Value="11.9" />
                        <Setter Property="Background" Value="#12181F25" />
                    </Trigger>
                </Style.Triggers>
            </Style>
            <Style TargetType="Span">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="CodeSpan">
                        <Setter Property="FontFamily" Value="Courier New" />
                        <Setter Property="FontSize" Value="11.9" />
                        <Setter Property="Background" Value="#12181F25" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="Hyperlink">
                <Setter Property="TextDecorations" Value="None" />
            </Style>

            <Style TargetType="Image">
                <Setter Property="RenderOptions.BitmapScalingMode" Value="NearestNeighbor" />
                <Style.Triggers>
                    <Trigger Property="Tag" Value="imageright">
                        <Setter Property="Margin" Value="20,0,0,0" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <!--
                The Table's style don't seem to support border-collapse.
                By making the ruled line width 0.5 and applying it to cell and table,
                it looks like the ruled lines are not doubled.
            -->
            <Style TargetType="Table">
                <Setter Property="CellSpacing" Value="0" />
                <Setter Property="BorderThickness" Value="0.5" />
                <Setter Property="BorderBrush" Value="#DFE2E5" />
                <Style.Resources>
                    <Style TargetType="TableCell">
                        <Setter Property="BorderThickness" Value="0.5" />
                        <Setter Property="BorderBrush" Value="#DFE2E5" />
                        <Setter Property="Padding" Value="13,6" />
                    </Style>
                </Style.Resources>
            </Style>

            <Style TargetType="TableRowGroup">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="TableHeader">
                        <Setter Property="FontWeight" Value="DemiBold" />
                        <Setter Property="FontWeight" Value="Bold" />
                        <Setter Property="Background" Value="#FFFFFF" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="TableRow">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="EvenTableRow">
                        <Setter Property="Background" Value="#F6F8FA" />
                    </Trigger>
                </Style.Triggers>
            </Style>

            <Style TargetType="BlockUIContainer">
                <Style.Triggers>
                    <Trigger Property="Tag" Value="RuleSingle">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleDouble">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleBold">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>

                    <Trigger Property="Tag" Value="RuleBoldWithSingle">
                        <Setter Property="Margin" Value="0,3" />
                    </Trigger>
                </Style.Triggers>
            </Style>
        </Style.Resources>
    </Style>
</ResourceDictionary>
```
