   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.MiniPages.EventShortBody.MiniPages.Event  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  0    *ShortBody.MiniPages.Event.EventDetailsMini   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:ShortBody.MiniPages.Event     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  0cv'clr-namespace:ShortBody.ValueConverters  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    � 	Resources   �� 
TargetType   DataGridButton �� Property �� Value��%C   &	        �� " ��.���  � ��$ 30����  � ��$ 30��.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $��All Members��  head#��[ $��1���� $��
Attendants��#��[ $��1��$��1��� $��1��$��10q�  MaterialDesignPaper#���   �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��5q�$��Center=�
���   � �� Padding$ 5q� �� CornerRadius$ 5��$��2q�._��� $��14(�$��Search Members���� $��1��$��Center=� �� Orientation$ 
Horizontal=�$��Center=�$��5q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchMembers��$	��100��$��Center=�$��5,0,5,0q�	 �� Text	 �� *SearchMembersBy+@��� $	��All���� $
��Name���� $
��Area���� -   $��txtSearchMembers��$	��150��$��10,0,5,0q����� *SearchMembersString+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchMembersCommand+.��"  FontAwesome.WPF.ImageAwesome     Icon$ Search=�$��30���� $��2��$ 
Horizontal=�$��Center=�.+���  �� TextWrapping$
 Wrap=�$	��400��$	��400������ *MTickString+�� $��AutoTick��$��10q����� *Tick+� $��1��$��1��$��10q�$
��auto��#���   �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��5q�$��Center=�
���   �$ 5q�$ 5��$��2q�._��� $��14(�$��Search Attendants���� $��1��$ 
Horizontal=�$��Center=�$��5q�$��Center=�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchAttendants��$	��100��$��Center=�$��5,0,5,0q�	 �� *SearchAttendantsBy+@��� $	��All���� $
��Name���� $
��Area���� -   $��txtSearchAttendants��$	��150��$��10,0,5,0q����� *SearchAttendantsString+$
 PropertyChanged=�$ TwoWay=��� #��[ $��17(�$��5,0,5,0q����� *SearchAttendantsCommand+.��  $ Search=�$��30���� $��2��$ 
Horizontal=�$��Center=�.+��� $
 Wrap=�$	��400��$	��400������ *AttTickString+�� $��
AutoUnTick��$��10q����� *UnTick+&   System.Windows.Controls.DataGrid  -   $��AllPeopleGrid��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��5q�$	��400��   CanUserAddRows .     AutoGenerateColumns .  $��2������ *	Members+$
 PropertyChanged=�$ TwoWay=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 50    Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
PersonId+4  .System.Windows.Controls.DataGridTemplateColumn  $ Picture��   CellTemplate �� .R�A� $��50��$��50������  �� ImageSource �� *	Picture+ �� 	Converter 4   .ShortBody.ValueConverters.ByteToImageConverter    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $
 Area�� �� *Group.Area.AreaName+  $  �� �� .R��� #��[  ���� *
AddCommand+ � DataContext ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext�.��  $ 
PlusSquare=�  -   $��AttendeesGrid��$ * $	��400�� .   .  $��5q�$��1��$��2������ *
Attendants+$
 PropertyChanged=�$ TwoWay=�   $ 50 $ Id�� �� *
PersonId+  $ Picture�� �� .R�A� $��50��$��50������  �� *	Picture+     $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $
 Area�� �� *Group.Area.AreaName+  $  �� �� .R��� #��[  ���� *RemoveCommand+ ��  �� " >�$ FindAncestor=�$ DataContext�.��  $ MinusSquare=�