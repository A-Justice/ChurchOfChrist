   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  "    ShortBody.Pages.FamiliesPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  0cv'clr-namespace:ShortBody.ValueConverters  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  FamiliesPage��.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $
��Name���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchFamilyCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Families��$��1��$��3��   CanClose .  	   Content	 �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�
 � ToolTip$
 Add New Family��  b_Button#��[ .��
Add Family�� 
�������$��1��$��5,5,5,5q��� $��5,5,5,5q�#��[ ���� *DeleteFamilyCommand+.��Delete Family�� -   $��5,5,5,5q�#��[ .��Edit Family&   System.Windows.Controls.DataGrid  -   
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1��   CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(�   AutoGenerateColumns .  ���� *AllFamilies+$ PropertyChanged=�$ TwoWay=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Family Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
FamilyName+  $ Family Phone�� �� *FamilyPhone+  -     Name$ AddFamilyWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddFamilyWindow_Loaded��$��1��$��1��$ 
Add Family��$	��600��.	 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $
 Clear Boxes������ *
ClearBoxes+.��"  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�$��20��$��3,0,0,0q��� $��1��$��2��$
��Auto=�.��� #���    � DataContext �� *	NewFamily+ �� $
��auto ��� $
��auto ��� $	��87* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��1��$��2��.+��� $��1��$	��100��$	��100������ *	Picture+$ PropertyChanged=�$ TwoWay=� �� 	Converter 4	   .ShortBody.ValueConverters.ByteToImageConverter	  �� $��Choose Family Picture��$��30��$��10q�$	��150�� ��  �� " N�$ FindAncestor=�$ DataContext����� *BrowsePicCommand+�� $��5q�$��2��.+��� #��[ $��Family Name :��$ Right=�$��10q�$��Center=��� #��[ $��Family Phone :��$ Right=�$��10q�$��Center=��� #��[ $��Clan :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��2��.+��� $��	5,10,5,10q����� *
FamilyName+�� $��	5,10,5,10q����� *FamilyPhone+�� $��	5,10,5,10q����� *Clan+�� $��2��$��5q�$��2��.+��� #��[ $��	Address :��$ Right=�$��10q�$��Center=��� #��[ $��FamilyHead Name :��$ Right=�$��10q�$��Center=��� #��[ $��FamilyHead Contact :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��2��.+��� $��	5,10,5,10q����� *	Address+�� $��	5,10,5,10q����� *FamilyHeadName+�� $��	5,10,5,10q����� *FamilyHeadContact+�� -   $
��Save��$��10q�$��70�� ��  �� " N�$ FindAncestor=�$ DataContext����� *SaveNewFamilyCommand+�� -   $��Save Changes��$��10q�$��70��$y�	Collapsed=� ��  �� " N�$ FindAncestor=�$ DataContext����� *EditFamilyCommand+  -	   $ FamilyWindow��$ FamilyWindow_Loaded��$��1��$��1��$	��600��$	��630��$y�	Collapsed=�.	 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� -
   $��5q�$
 Add New Family��#��[ .��	Details � -   $��1��$��2��