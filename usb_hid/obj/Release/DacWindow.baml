   M S B A M L   `   `   `  ���� B  >usb_hid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:usb_hidusb_hid  =#clr-namespace:usb_hid.usecontrolusbusb_hid.usecontrolusb      usb_hid.DacWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:usb_hid     2uc#clr-namespace:usb_hid.usecontrolusb     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��
Mainwindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� 	 DacVM � DataContext# [ $��5 5 5 5q� � Title$ 
MainWindow��$	��500��$	��500��.���  � RowDefinitions �� $
��auto ��� $
��auto �.+�� $��0��$
��auto��.+�(   "usb_hid.usecontrolusb.ControlBarUC  
 � Tag �� *Title+	 �� ElementName$	 
Mainwindow��� $��1�� �� $
��auto ��� .+��� $��0��.+�#  MaterialDesignThemes.Wpf.Card  $��5q�.��� 
 � Orientation$
 
Horizontal=�$
��Left=�.+��� $��20 50 20 50q�$��Center=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Channel select�� % !MaterialDesignFloatingHintTextBox#��[ $��Center=����� *DacSelChannel+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� $��20 50 20 50q�$ Value convert��#��[ $��Center=����� *DacSelConvert+$ PropertyChanged=�$ TwoWay=���  �� Orientation$ 
Horizontal=�.+��� $��30(�$
��auto��  MaterialDesignFlatButton#��[  � ToolTip$ MaterialDesignFlatButton��$��UPDATE������ *DacUpdateCommand+�� $��30(�$
��auto��#��[ $ MaterialDesignFlatButton��$��ACCEPT������ *	DacSend+  $��1��$��5q�$��Stretch=�.���� ���� *	ItemDac+ �� SelectedItem �� *SelectedItemsDac+$ OneWayToSource=� �� View �� .P��� $��Channel�� �� DisplayMemberBinding �� *
DacChannel+�� $��Value�� �� *
DacConvert+�� $��Description�� �� *Des+