   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  &     ShortBody.Reports.AnalysisReport   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ShortBody.Reports     6cv'clr-namespace:ShortBody.ValueConverters     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/    � WindowState$  	Maximized=� � Title$ AnalysisReport��$	��450��$	��800��.���� $
��Auto=�.���  � RowDefinitions �� $
��auto ��� $
��auto �.+��� -   $��TopPanel�� �� Orientation$ 
Horizontal=�$��5q�.+��� -   .��"  FontAwesome.WPF.ImageAwesome     Icon$ Print=�$��40��$��5q� � ToolTip$ Print���� -   $��
MainBorder��$��1�� �� Padding$ 20q�._�� $��Center=� � 	Resources  �� 
TargetType	 �� BasedOn
 �� Property �� Value��%P   '��       7���� " ��8	   .��� 
 � ��$ Tahoma)��� 
 � ��$ 13(� �� $
��auto ��� $
��auto ��� $
��auto �.+���    DeepBlue#��[  $��2��._��� $��Center=�$��Center=�.+��� $��Center=�$��18(����#F7F4F7$��10q����� *AnalysisNature+�� $��Center=�$��	10,5,10,5q�
�������$��2q�._��� $��Center=�$ 
Horizontal=�.+��� $��TOTAL DAYS �����#F7F4F7 �� Padding$ 5q�$��5q��� $��5q�$ 5q�$
��Bold"����#F7F4F7���� *	TotalDays+&   System.Windows.Controls.DataGrid     AutoGenerateColumns .     CanUserAddRows .  $��1������ *AllAnalysis+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ Members�� �� *TotalMembers+  $ SundaysAttendance�� �� *SundaysAttendants+  $ TuesdaysAttendance�� �� *TuesdaysAttendants+  $ FridaysAttendantce�� �� *FridaysAttendants+  $ Total�� �� *Total+  $ ExpectedAttendance�� �� *ExpectedAttendance+  $ Sun(%)�� �� *
SunPercent+ �� 	Converter -   'ShortBody.ValueConverters.DToSConverter    $ Tue(%)�� �� *
TuePercent+     $ Fri(%)�� �� *
FriPercent+   