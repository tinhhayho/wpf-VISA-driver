   M S B A M L   `   `   `  ���� B  >usb_hid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:usb_hidusb_hid  =#clr-namespace:usb_hid.usecontrolusbusb_hid.usecontrolusb      usb_hid.PwmWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:usb_hid     2uc#clr-namespace:usb_hid.usecontrolusb     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
Mainwindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   	 PwmVM � DataContext# [  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��5 5 5 5q� � Title$ 
PWM Window��$	��500��$	��680��.���  � RowDefinitions �� $
��auto ��� $
��auto �.+�� $��0��$
��auto��.+�(   "usb_hid.usecontrolusb.ControlBarUC  
 � Tag �� *Title+	 �� ElementName$	 
Mainwindow��� $��1�� �� $
��auto ��� �� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��0��.��� $��0��$	��Top=�
 � ColumnDefinitions
 �� $	��250 ��� .+���  �� Orientation$ Vertical=�$��Center=�$��0��.+��� $��	CHANNEL 1��$��	5 20 5 20q�$��Center=�$��Center=�$	��200�� $  MaterialDesignHeadline4TextBlock#��[ ��   MaterialDesignRaisedButton#���  +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�$��WRITE��$	��200��$��Center=����� *Write1Command+�� $��1��$ 
Horizontal=�.+��� $ Vertical=�$��
 2 20 2 20q�.+��� $ 
Horizontal=�$��Center=�.+��� $	��PWM��$��	20 2 20 2q�d�  ( $MaterialDesignSwitchDarkToggleButton#��[  � ToolTip$* $MaterialDesignSwitchDarkToggleButton�� d� 	IsChecked$ FalseY�$��	20 2 20 2q��� $	��PTO��$��	20 2 20 2q�d� #��[ $* $MaterialDesignSwitchDarkToggleButton��$ FalseY�$��	20 2 20 2q��� $ 
Horizontal=�$��0 16 0 0q�.+��� -    ��Name$ sliderMaxH1��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Max Frequency��$��5 5 10 0q� % !MaterialDesignFloatingHintTextBox#��[ $��Center=���  � Minimum$ 0Q�   MaterialDesignDiscreteSlider#��[ $" MaterialDesignDiscreteSlider��$	��280�� � Maximum �� *Text+$	 sliderMaxH1�� � Value �� *NormalFrequency1+ �� Mode$ OneWayToSource=��� $ 
Horizontal=�$��0 16 0 0q�.+��� -   $ sliderMaxH2��$ Max Duty Cycle��$��5 5 10 0q�#��[ $��Center=��� $ 0Q�#��[ $" MaterialDesignDiscreteSlider��$	��280�� �� *Text+$	 sliderMaxH2�� �� *Duty1+$ OneWayToSource=��� $��1��  	 MaterialDesignLightSeparator#��[	   $��2��.��� $��2��$	��Top=�
 �� $	��250 ��� .+��� $ Vertical=�$��Center=�$��0��.+��� $��	CHANNEL 2��$��	5 20 5 20q�$��Center=�$��Center=�$	��200��#��[ �� #���  $ Depth5=�$��WRITE��$	��200��$��Center=����� *Write2Command+�� $��1��$ Vertical=�.+��� $ Vertical=�$��
 2 20 2 20q�.+��� $ 
Horizontal=�$��Center=�.+��� $	��PWM��$��	20 2 20 2q�d� #��[ $* $MaterialDesignSwitchDarkToggleButton��$ FalseY�$��	20 2 20 2q��� $	��PTO��$��	20 2 20 2q�d� #��[ $* $MaterialDesignSwitchDarkToggleButton��$ FalseY�$��	20 2 20 2q��� $ 
Horizontal=�$��0 16 0 0q�.+��� -   $ sliderMaxH3��$ Max Frequency��$��5 5 10 0q�#��[ $��Center=��� $ 0Q�#��[ $" MaterialDesignDiscreteSlider��$	��280�� �� *Text+$	 sliderMaxH3�� �� *NormalFrequency2+$ OneWayToSource=��� $ 
Horizontal=�$��	0 16 0 20q�.+��� -   $ sliderMaxH4��$ Max Duty Cycle��$��5 5 10 0q�#��[ $��Center=��� $ 0Q�#��[ $" MaterialDesignDiscreteSlider��$	��280�� �� *Text+$	 sliderMaxH4�� �� *Duty2+$ OneWayToSource=�