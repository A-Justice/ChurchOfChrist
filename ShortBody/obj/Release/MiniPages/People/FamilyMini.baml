   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ShortBody.MiniPagesShortBody.MiniPages  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  $    ShortBody.MiniPages.FamilyMini   +local!clr-namespace:ShortBody.MiniPages  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6cv'clr-namespace:ShortBody.ValueConverters     W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    � 	Resources     	tbOutline �� 
TargetType  tb �� BasedOn �� Property �� Value��%�   &	        7  &	 @     7  �� " ��8   .���  � ��$
 Bold"���  � ��$ 14(��� " ��8   .���  � ��$ 14(�.���   MaterialDesignPaper#���   � DataContext �� *SelectedPerson.Family+ � RowDefinitions �� $
��auto ��� $
��auto ��� $
��Auto ��� $	��87* � � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+��� $��1��$��1��$��2��.+��� $	��200��$
��auto��$��10q����� *	Picture+ �� 	Converter 4   .ShortBody.ValueConverters.ByteToImageConverter  �� $��Family Members��$��2��$��4��  head#��[ &   System.Windows.Controls.DataGrid  $��3��$��4��$��Center=�	   AutoGenerateColumns	 .  ���� *FamilyMembers+
   Columns
 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Picture��   CellTemplate �� .R��� $��70��$��70������ *	Picture+   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  $ 	FirstName��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	FirstName+  $ LastName�� �� *
LastName+  $
 Area�� �� *Group.Area.AreaName+  $ Service�� �� *	Service+