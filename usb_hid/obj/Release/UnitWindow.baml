   M S B A M L   `   `   `  ���� B  >usb_hid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:usb_hidusb_hid  =#clr-namespace:usb_hid.usecontrolusbusb_hid.usecontrolusb      usb_hid.UnitWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:usb_hid     2uc#clr-namespace:usb_hid.usecontrolusb     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
Unitwindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   	 AdcVM � DataContext# [  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � Title$ 
ADC WINDOW��$	��450��$	��400��.���  � RowDefinitions �� $
��auto ��� .+�� $��0��.+�(   "usb_hid.usecontrolusb.ControlBarUC  
 � Tag �� *Title+	 �� ElementName$	 
Unitwindow��� $��1�� �� $
��auto ��� .+�#  MaterialDesignThemes.Wpf.Card  $��0��$��5q�.��� 
 � Orientation$
 
Horizontal=�$
��Left=�.+��� $��20 50 20 50q�$��Center=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Channel select�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=����� *AdcSelChannel+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=��� $��20 50 20 50q�$ Value��#��[ $��Center=����� *AdcSelValue+$ PropertyChanged=�$ OneWay=��� $��20 50 20 50q�$ Value convert��#��[ $��Center=����� *AdcSelConvert+$ PropertyChanged=�$ OneWay=�  $��1��$��5q�$��Stretch=�.���� ���� *	ItemAdc+ �� SelectedItem �� *SelectedItem+$ OneWayToSource=� �� View �� .P��� $��Channel�� �� DisplayMemberBinding �� *
AdcChannel+�� $��Value�� �� *
AdcValue+�� $��Description�� �� *Des+