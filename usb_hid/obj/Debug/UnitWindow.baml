   M S B A M L   `   `   `  ����B  >usb_hid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:usb_hidusb_hid  5   	   =#clr-namespace:usb_hid.usecontrolusbusb_hid.usecontrolusb  5   	       usb_hid.UnitWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:usb_hid     5   	   2uc#clr-namespace:usb_hid.usecontrolusb     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5        $��
Unitwindow��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    	 AdcVM � DataContext# [ 5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
ADC WINDOW��5   	   $	��450��6   $	��400��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (   "usb_hid.usecontrolusb.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 
Unitwindow��6N   5      � 5    
   $��1��6    5!      �� 5"      $
��auto �6    60   �� 5#      6"   .+�5%      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5&      � 
 � Orientation$
 
Horizontal=�6   $
��Left=�65   .+�5'      �� $��20 50 20 50q�5)      $��Center=�5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Channel select��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      $��Center=�5-      ��5(      �� *AdcSelChannel+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=�5-      �� 5.      $��20 50 20 50q�50      $ Value��51      #��[ 52      $��Center=�53      ��5/      �� *AdcSelValue+$ PropertyChanged=�$ OneWay=�53      �� 54      $��20 50 20 50q�56      $ Value convert��57      #��[ 58      $��Center=�59      ��55      �� *AdcSelConvert+$ PropertyChanged=�$ OneWay=�59      5:      5;        5=      $��1��6"   $��5q�6/   $��Stretch=�6:   .��5?      �� ��6   �� *	ItemAdc+ �� SelectedItem 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5@      �� 5A      .P�5B      �� $��Channel��5C   .    �� DisplayMemberBinding 5B   .   �� *
AdcChannel+5C   .   �� 5D      $��Value��5E   .    5D   .   �� *
AdcValue+5E   .   �� 5F      $��Description��5G   .    5F   .   �� *Des+5G   .   5H      5J      5K      5M      5O      5P      