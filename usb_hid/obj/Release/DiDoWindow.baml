   M S B A M L   `   `   `  ���� B  >usb_hid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:usb_hidusb_hid  =#clr-namespace:usb_hid.usecontrolusbusb_hid.usecontrolusb      usb_hid.DiDoWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:usb_hid     2uc#clr-namespace:usb_hid.usecontrolusb     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
Mainwindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   
 DiDoVM � DataContext# [  � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��5 5 5 5q� � Title$ DiDo Window��$	��400��$	��700��.���  � RowDefinitions �� $
��auto ��� .+�� $��0��$
��auto��.+�(   "usb_hid.usecontrolusb.ControlBarUC  
 � Tag �� *Title+	 �� ElementName$	 
Mainwindow��� $��1�� �� $
��auto ��� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��	5 20 5 20q�$
�� 150��$	��650��.���� 
 �� Orientation$
 Vertical=�.+�    PrimaryHueLightBrush#���   " PrimaryHueLightForegroundBrush#���  $	��200��$��8q�.���� $��DO�� $  MaterialDesignHeadline3TextBlock#��[ $��Center=��  � Orientation$ 
Horizontal=�$��Center=�$��Bottom=�$��60��$	��600��.+�d� -   $	��Do0��$��0��$��Center=�$��20 10 20 10q� $  MaterialDesignActionToggleButton#��[  � ToolTip$&  MaterialDesignActionToggleButton��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=����� *
Do0Command+���� $		 Do0��d� -   $	��Do1��$��1��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do1Command+���� $		 Do1��d� -   $	��Do2��$��2��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do2Command+���� $		 Do2��d� -   $	��Do3��$��3��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do3Command+���� $		 Do3��d� -   $	��Do4��$��4��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do4Command+���� $		 Do4��d� -   $	��Do5��$��5��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do5Command+���� $		 Do5��d� -   $	��Do6��$��6��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do6Command+���� $		 Do6��d� -	   $	��Do7��$��7��$��20 10 20 10q�#��[ $&  MaterialDesignActionToggleButton��$ Depth3=����� *
Do7Command+���� $		 Do7��  $��1��$��	5 20 5 20q�$	��150��$	��650��.���� $
 Vertical=�.+�  #���  #���  $	��200��$��8q�.���� $��DI��#��[ $��Center=��� $��Stretch=�.+�� $ 
Horizontal=�$��Stretch=�$��Center=�$��60��$	��650��.+�A� $��30��$��30��$��20 10 20 10q����� *Di0+A� $��30��$��30��$��20 10 20 10q����� *Di1+A� $��30��$��30��$��20 10 20 10q����� *Di2+A� $��30��$��30��$��20 10 20 10q����� *Di3+A� $��30��$��30��$��20 10 20 10q����� *Di4+A� $��30��$��30��$��20 10 20 10q����� *Di5+A� $��30��$��30��$��20 10 20 10q����� *Di6+A� $��30��$��30��$��20 10 20 10q����� *Di7+