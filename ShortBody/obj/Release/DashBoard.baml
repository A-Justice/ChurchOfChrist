   M S B A M L   `   `   `  ���� Z  VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466J6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPFFontAwesome.WPF  D @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters %clr-namespace:ShortBody	ShortBody S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls    ShortBody.DashBoard   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Efa6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPF     6cv'clr-namespace:ShortBody.ValueConverters     )localclr-namespace:ShortBody     >ctr.clr-namespace:ShortBody.Resources.UserControls     -   
�������.���    myLightDark#��[    � RowDefinitions  �� $
��Auto ��� $��* � � ColumnDefinitions �� $
��Auto ��� $��* �.+�� $��2��  DeepBlue#��[  �� $
��auto ��� $
��auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��auto �.+�A� $��40��$��40��$��5q�����  j� Stretch$ UniformToFill=� �� ImageSource �� *Logo+ �� IsAsync .  �� 	Converter 4  .ShortBody.ValueConverters.ByteToImageConverter   �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��20(�$��	10,0,10,0q� �� TextAlignment$
 Left=�$��Center=����� *
ChurchName+�� -   $��	TopHeader��$��Center=�$��Algerian)�$��Center=�$��15(�$��2��$��People��A� $��4��$��Center=�$��5q�$��40��$��40�� � DataContext �� *CurrentUser+���� $ UniformToFill=� �� *	UserImage+ . $ PropertyChanged=�   �� $��5q�$��3��	 �� Orientation$	 
Horizontal=�.+��� $��Welcome��$��Center=�$��10,0,3,0q��� $��Center=�$��3,0,5,0q�$ Center=� �� *CurrentUser+���� *	FirstName+�� $��5��$	 
Horizontal=�.+�7  1ShortBody.Resources.UserControls.NotificationIcon  -   
  Name$
 v��$��Center=�   Count$
 Paid�� � Cursor$
 Hand��$��Center=�$��40��$��40��
�������.��"   FontAwesome.WPF.ImageAwesome     Icon$ BirthdayCake=�   
Foreground
 �����  -   $
 btnBirthDayNotification��7  1ShortBody.Resources.UserControls.NotificationIcon   Click$# btnBirthDayNotification_Click��$��Center=�$
 Hand�� � ToolTip$ 	BirthDays��$��Center=�$��30��$��30��
�������.��  $ BirthdayCake=�
 ������� -   $��btnSettings��$��Center=�$
 Hand��$ Settings��$��Center=�$��30��$��30��
�������$��5q�.��  $
 Gear=�
 ������� $��Logout��$��10q�$
 Hand��
����������� *LogoutCommand+�� -   $��btnToggleSideNav��$��50��$��50��$
��Left=�$��0q�$	��1,5q�$��1��$	��Top=�.��  $ Navicon=�$��30��
 ������� -    ��Name$ SideNav��$��1��
������ $��5,50,0,0q�$��45��
�������
������ $
��Left=�.@��� -   $��	spSideNav��|�.  .+�2  ,ShortBody.Resources.UserControls.LinedButton  -	     Name$ btnShowPeople��2  ,ShortBody.Resources.UserControls.LinedButton   Click$ LinedButton_Click��$	��1,5q�$��50��   ShowLine . ���� *OpenClients+.���� $	 
Horizontal=�.+�  $
 User=�
 �����$��30���� $��People��$
��Bold"�$	��100��$��18(� �� Padding$ 5q�
�������$��Center=�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenServices+.���� $	 
Horizontal=�.+�  $ Group=�$��30��
 ������� $��Associations��$
��Bold"�$	��100��$��18(�$ 5q�
�������$��Center=�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenAttendance+.���� $	 
Horizontal=�.+�  $	 Car=�$��30��
 ������� $��
Attendance��$
��Bold"�$	��115��$��18(�$ 5q�
�������$��Center=�  -
   $ btnFamilies��$ LinedButton_Click��$	��1,5q�$��50������ *OpenFamilies+.���� $	 
Horizontal=�.+�  $ Circle=�$��30��
 ������� $��Families��$
��Bold"�$	��115��$��18(�$ 5q�
�������$��Center=�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenReports+.���� $	 
Horizontal=�.+�  $ NewspaperOutline=�$��30��
 ������� $��Reports��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q�  -   $ btnChurches��$ LinedButton_Click��$	��1,5q�$��50������ *OpenChurches+.���� $	 
Horizontal=�.+�  $ Industry=�$��30��
 ������� $��Churches��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q�  -   $ btnUsers��$ LinedButton_Click��$	��1,5q�$��50������ *	OpenUsers+.���� $	 
Horizontal=�.+�  $ Bandcamp=�$��30��
 ������� $��Users��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q��� $
��Auto=�$��1��$��1��.�� � $	��675��$	��Top=�  
ShinyWhite#��[   � NavigationUIVisibility$ Hidden=����� *DashBoardPage+$ PropertyChanged=� 6  0ShortBody.ValueConverters.DashBoardPageConverter  