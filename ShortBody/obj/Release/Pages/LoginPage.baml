   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages      ShortBody.Pages.LoginPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     -   $	��550��$	��230��.���    MaterialDesignPaper#��[    � ColumnDefinitions  �� $��* ��� $
��Auto �.+��   	sideImage#��[  � RowDefinitions �� $	��19* ��� $	��76* ��� $	��20* �.+�(� $��1��$��10q�� $��1��$��10q�  �� $
��Auto ��� $
��Auto �.+��� $��10,15,10,10q�.+���   tb#��[ $��Church Name :�� �� TextAlignment$ Center=�$��Right=�$
��0,10q��� #��[ $��
Username :��$ Center=�$��Right=�$
��0,10q��� #��[ $��
Password :��$ Center=�$��Right=�$
��0,10q��� $��1��$��10q�.+��� $	��150��$
��0,10q����� *
Churches+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem �� *SelectedChurch+���� .R��� ���� *Name+�� $
��0,10q����� *
UserName+$ PropertyChanged=�$ TwoWay=�G� -   $��
PbPassword��$
��0,10q��� $��LogIn��$
��0,10q�$��70������ *LoginCommand+