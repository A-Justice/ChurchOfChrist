   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.EventsPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  0cv'clr-namespace:ShortBody.ValueConverters  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    N� ShowsNavigationUI  .   � 	Resources ��%    .���� $
��Auto=�$
��Auto=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $	��Day���� $��Month���� $
��Year���� -   $��cboSearchMonth��$y�	Collapsed=�$��80�� �� *SearchString+@��� $��January���� $��February���� $��March���� $��April���� $	��May���� $
��June���� $
��July���� $��August���� $��	September���� $��October���� $��November���� $��December���� -   $��cboSearchDay��$y�	Collapsed=�$��80�� �� *SearchString+@��� $��Sunday���� $��Tuesday���� $��Friday���� -   $��cboSearchYear��$y�	Collapsed=�$��80������ *Years+ �� *SearchString+��   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchEventCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ 
All Events��$��1��$��3��   CanClose .  $	��260��$
��Left=�   Content �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�	 � ToolTip$	 Add New Event��  b_Button#��[ .��	Add Day�� 
�������$��1��$��5,5,5,5q��� $��5,5,5,5q�#��[ ���� *DeleteEventCommand+.��
Delete Day�� -   $��5,5,5,5q�#��[ ���� *EditClickCommand+.��
Edit Day&   System.Windows.Controls.DataGrid  -   
���   �
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * $��1��   CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(�   AutoGenerateColumns .  ���� *	AllEvents+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Date+ �� 	Converter 1   +ShortBody.ValueConverters.LongDateFormatter    -     Name$ AddEventWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddEventWindow_Loaded��$��1��$��1��$ Add Day��$	��600��. �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.��"	  FontAwesome.WPF.ImageAwesome	   	  Icon$ 
PaintBrush=�$��20��$��3,0,0,0q��� $��1��$��2��$
��Auto=�.��� #���    � DataContext �� *
NewEvent+ �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � .+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��5q�$��2��.+�(
  "System.Windows.Controls.DatePicker
  $��Center=�$	��250��$��20(�$��	5,10,5,10q�  
  SelectedDateFormat$
  Long=�! 
  DisplayDate! �� *Date+" 
  SelectedDate" �� *Date+$ PropertyChanged=�$ TwoWay=��� $��3��.+��� -	   $	��Add��$��10q�$��70�� ��  �� " N�$ FindAncestor=�$ DataContext����� *SaveNewEventCommand+�� -
   $��Save Changes��$��10q�$��70��$y�	Collapsed=� ��  �� " N�$ FindAncestor=�$ DataContext����� *EditEventCommand+  -   $ EventWindow��$��1��$��1��$
��1100��$	��630��$y�	Collapsed=�. �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� -   $��5q�$	 View Event's Details��#��[ .��	Details�� $��1��$��2��$
��Auto=�.�� � -   