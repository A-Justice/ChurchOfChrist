   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.WindowsShortBody.Windows  ,    &ShortBody.Windows.MasterPasswordWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ShortBody.Windows     -     � WindowStartupLocation$  CenterScreen=�   MaterialDesignPaper#��[   � Icon$  /Resources\Images\icon.ico�� � Title$ Enter Master Password��$	��315��$	��180��$	��315��.��� .+��� .+��� -   $��spTop��.+��� -   $��topError��
�������$
��Bold"� �� TextAlignment$ Center=�$��15(���  �� Orientation$ 
Horizontal=�$��20q�.+��� $��Master Password :��$��Center=�G� -   $��
tbPassword��$	��150��$��5q��� $ 
Horizontal=�$��Right=�.+��� -   $��btnChangePassword��$��Change Password��  b_Button#��[ $��10q��� -    ��Name$ btnOk��$��OK��$��10q�#��[ �� -   $��spBottom��$y�	Collapsed=�.+��� -   $��	downError��
�������$
��Bold"�$ Center=�$��15(��� $ 
Horizontal=�$��10q�.+��� $��Enter Old Password :��$ Right=�$	��125��$��Center=�G� -	   $��tbOldPassword��$	��150��$��5q��� $ 
Horizontal=�$��10q�.+��� $��New Password :��$	��125��$ Right=�$��Center=�G� -
   $��tbNewPassword��$	��150��$��5q��� $ 
Horizontal=�$��10q�.+��� $��Confirm New Password :��$	��125��$ Right=�$��Center=�G� -   $��tbConfirmNewPassword��$	��150��$��5q��� $ 
Horizontal=�$��Right=�.+��� -   $��btnBack��$
��Back��$��10q�#��[ �� -   $��	btnChange��$��Change��$��10q�#��[ 