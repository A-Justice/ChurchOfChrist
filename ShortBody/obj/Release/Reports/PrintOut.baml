   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5clr-namespace:ShortBody.ReportsShortBody.Reports       ShortBody.Reports.PrintOut   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     6cv'clr-namespace:ShortBody.ValueConverters     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  +localclr-namespace:ShortBody.Reports    � WindowStartupLocation$  CenterScreen=� � WindowState$ 	Maximized=�$
��1500��$
��2000�� � Title$ PrintOut��.���� $
��Auto=���. .���  � RowDefinitions �� $
��auto ��� $
��auto �.+��� -   $��TopPanel�� �� Orientation$ 
Horizontal=�$��5q�.+��� -   .��"  FontAwesome.WPF.ImageAwesome     Icon$ Print=�$��40��$��5q� � ToolTip$ Print���� -   $��
MainBorder��$��1�� �� Padding$ 20q�._�� $��Center=� � 	Resources 	 �� 
TargetType
 �� BasedOn �� Property �� Value��%P   '��       7���� "	 ��8
   .���  � ��$ Tahoma)���  � ��$ 13(� �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $	��770 ��� $	��541 �.+���    DeepBlue#��[  $��2��._��� $��Center=�$��Center=�.+��� $��Center=�$��18(����#F7F4F7$��10q����� *PrintArea.AreaName+�� $��Center=�$��	10,5,10,5q�
�������$��2q�._��� $��Center=�$ 
Horizontal=�.+��� $��AREA LEADER �����#F7F4F7 �� Padding$ 5q�$��5q��� $��5q�$ 5q�$
��Bold"����#F7F4F7���� *PrintArea.AreaLeaderId+ �� 	Converter 3   -ShortBody.ValueConverters.IdToPersonConverter  &   System.Windows.Controls.DataGrid  $��1��{�.    CanUserAddRows .  $
��1440��$
��1440��   CanUserSortColumns .     CanUserReorderColumns .     CanUserResizeColumns .    borderedCell   	CellStyle# [   printOuttHeaderStyle   ColumnHeaderStyle# [    AutoGenerateColumns .  $��2������ *
PrintOut+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60    Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Person.PersonId+  $	 170 $
 Name�� �� *Person.FullName+  $	 100 $ Phone�� �� *Person.Phone+  $ 35 $	 Sun�� �� *	Sundays+  $ 35 $	 Tue�� �� *
Tuesdays+  $ 35 $	 Fri�� �� *	Fridays+  $ 45 $	 Sum�� �� *Total+  $	 290 $ Remarks�� �� *Remark+  $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30   $ 30    RowStyle �� )  #System.Windows.Controls.DataGridRow"	  .���  � �� �� *Person.Group.Name+ 6	   0ShortBody.ValueConverters.RowBackgroundConverter	  �� $��1��$��1��
�������$	��Top=�.+��  �� $	��435 ��� $	��104 �.+��� $��Center=�$ 
Horizontal=�
�������.+���  �� TextAlignment$ Center=����� *
PrintMonth+ 3
   -ShortBody.ValueConverters.IntToMonthConverter
   �� FallbackValue$ [Month]���� $��, ���� $ Center=����� *	PrintYear+$ [Year]���� $��1��$��Center=�$ 
Horizontal=�
�������.+��� $��Center=�$ Center=����� *NextPrintMonth+ 
  $ [Month]���� $��, ���� $��Center=�$ Center=����� *NextPrintYear+$ [Month]���� -   $��stpWeeks��$ 
Horizontal=�.+��� ���#D9D9D9$��Week 1��$ Center=�$��90���� ���#D9C1D9$��Week 2��$ Center=�$��90���� ���#D9D9D9$��Week 3��$ Center=�$��90���� ���#D9C1D9$��Week 4��$ Center=�$��90���� ���#D9D9D9$��Week 5��$ Center=�$��90���� ���#D9C1D9$��Week 1��$ Center=�$��90���� -   $��stpDates��$ 
Horizontal=�.+��� -   $��stpWeek1��$��90��$ 
Horizontal=��� -   $��stpWeek2��$��90��$ 
Horizontal=��� -   $��stpWeek3��$��90��$ 
Horizontal=��� -	   $��stpWeek4��$��90��$ 
Horizontal=��� -
   $��stpWeek5��$��90��$ 
Horizontal=��� -   $��	stpWeek_1��$��90��$ 
Horizontal=�