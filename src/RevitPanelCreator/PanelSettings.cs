<Window x:Class="RevitPanelCreator.PanelDialog"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Revit Panel Creator"
        Width="420"
        Height="420"
        WindowStartupLocation="CenterScreen"
        ResizeMode="NoResize">
    <Grid Margin="16">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="120"/>
        </Grid.ColumnDefinitions>

        <TextBlock Grid.Row="0" Grid.ColumnSpan="2" Text="Create panel wall grid" FontSize="18" FontWeight="Bold" Margin="0,0,0,12"/>

        <TextBlock Grid.Row="1" Grid.Column="0" Text="Panel width (mm):" VerticalAlignment="Center"/>
        <TextBox x:Name="WidthTextBox" Grid.Row="1" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="2" Grid.Column="0" Text="Panel height (mm):" VerticalAlignment="Center"/>
        <TextBox x:Name="HeightTextBox" Grid.Row="2" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="3" Grid.Column="0" Text="Gap (mm):" VerticalAlignment="Center"/>
        <TextBox x:Name="GapTextBox" Grid.Row="3" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="4" Grid.Column="0" Text="Rows:" VerticalAlignment="Center"/>
        <TextBox x:Name="RowsTextBox" Grid.Row="4" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="5" Grid.Column="0" Text="Columns:" VerticalAlignment="Center"/>
        <TextBox x:Name="ColumnsTextBox" Grid.Row="5" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="6" Grid.Column="0" Text="Start X (mm):" VerticalAlignment="Center"/>
        <TextBox x:Name="StartXTextBox" Grid.Row="6" Grid.Column="1" Margin="8"/>

        <TextBlock Grid.Row="7" Grid.Column="0" Text="Start Y (mm):" VerticalAlignment="Center"/>
        <TextBox x:Name="StartYTextBox" Grid.Row="7" Grid.Column="1" Margin="8"/>

        <Button Grid.Row="9" Grid.ColumnSpan="2" Width="180" Height="36" Content="Create Panels" Click="CreateButton_Click" HorizontalAlignment="Center" VerticalAlignment="Bottom" Margin="0,10,0,0"/>
    </Grid>
</Window>
