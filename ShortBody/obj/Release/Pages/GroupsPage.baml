   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.GroupsPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     >ctr.clr-namespace:ShortBody.Resources.UserControls     6cv'clr-namespace:ShortBody.ValueConverters     W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  -     N� ShowsNavigationUI  .   N� Title$ 
GroupsPage�� � 	Resources  �� 
TargetType   tb �� BasedOn��%   '��       7   �� " ��8   .���� $
��Auto=�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��2��  myDirtyWhite#��[ $��20q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q�   
BlurRadius$ 3Q�._�� 	 � ColumnDefinitions	 �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+���   myMoreDirtyWhite#��[   head#��[ $��0��$��Zones��
 �� Padding$
 10q�   $ 2Q�$ 2Q�   	Direction$	 270Q�&   System.Windows.Controls.DataGrid  -   $��ZoneGrid��$��30q�$��5q�$��1��   AutoGenerateColumns .  $	��500��   CanUserAddRows .  ���� *Zones+   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Zone��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ZoneName+4  .System.Windows.Controls.DataGridTemplateColumn     Width5  /System.Windows.Controls.DataGridLengthConverter$ 60    CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� $��5q�$
��Zone�� � DataContext ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext����� *DeleteAssociationCommand+.��"  FontAwesome.WPF.ImageAwesome     Icon$ Trash=� � ToolTip$ Delete Zone��$��10��$��10���� $��2��$��5q�.+��� $��Add Zone��$��5q�#��[ �� $ 
Horizontal=�.+��� $��Zone Name :��$	��150�� �� TextAlignment$ Right=��� $	��150��$��5q����� *NewZoneName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� $	��100��$	��Add��$��5q�$
��Zone������ *AddAssociationCommand+�� $��1��$��1��$��2��.+��� $ 
Horizontal=�$��20 10 10 10q� �� *
ZoneLeader+.+��� $��0,0,10,0q�._�A� $��60��$��60������  �� ImageSource �� *	Picture+ �� 	Converter 4	   .ShortBody.ValueConverters.ByteToImageConverter	  �� .+���   J� SnapsToDevicePixels  . $��5q�  LeaderHeadBack#��[ ._��� 
�������$��12(�$
 	10,7,10,0q�$��Zone Leader���� $ 
Horizontal=�.+��� $ Center=�$��3q����� *	FirstName+! �� FallbackValue$! 	No Leader���� $ Center=�$��3q����� *
LastName+  -   $��dgZoneMembers�� .  $��10q�"   ColumnWidth$" *  .  $	��600������ *ZoneMembers+   $ 50 $ Id�� �� *
PersonId+  $ Picture��$
 auto  �� .R�A� $��60��$��60������ # j� Stretch$# UniformToFill=� �� *	Picture+ 	    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $  ��$ 60  �� .R��� $ 
Horizontal=�.+��� y��� *SelectedLeaderId+ <
   6ShortBody.ValueConverters.ContentToVisibilityConverter
   ��  �� " N�$ FindAncestor=�$ DataContext����� *SetAsLeaderCommand+���� $ �� ElementName$$ dgZoneMembers��.��  $ LifeRing=�$ Set As Leader��$��10��$��10���� $��1��$��2��#��[ $��20q�   $ 2Q�$ 3Q�._�� 	 �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� #��[ #��[ $��0��$��Areas��$
 10q�   $ 2Q�$ 2Q�$	 270Q�  -   $��AreaGrid��$��30q�$��4q�$��1�� .  $	��500�� .  ���� *Areas+   $
 Area�� �� *
AreaName+  $
 Zone�� �� *Zone.ZoneName+  $ 60  �� .R��� $ 
Horizontal=�.+��� $��5q�$
��Area�� ��  �� " N�$ FindAncestor=�$ DataContext����� *DeleteAssociationCommand+.��  $ Trash=�$ Delete Area��$��10��$��10���� $��2��$��5q�.+��� $��Add Area��$��5q�#��[ �� $ 
Horizontal=�.+��� $��Area Name :��$	��150��$ Right=��� $	��150��$��5q����� *NewAreaName+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� $��Zone :��$ Right=�$	��150���� $	��150��$��5q�% �� SelectedItem% �� *
AreaZone+���� *Zones+���� .R��� ���� *
ZoneName+�� $	��100��$	��Add��$��5q�$
��Area������ *AddAssociationCommand+�� $��1��$��1��$��2��.+��� $ 
Horizontal=�$��20 10 10 10q� �� *
AreaLeader+.+��� $��0,0,10,0q�._�A� $��60��$��60������  �� *	Picture+ 	  �� .+���   . $��5q�#��[ ._��� 
�������$��12(�$
 	10,7,10,0q�$��Area Leader���� $ 
Horizontal=�.+��� $ Center=�$��3q����� *	FirstName+$! 	No Leader���� $ Center=�$��3q����� *
LastName+  -   $��dgAreaMembers�� .  $	��550��$��1��$��2��$��10q�$" *  .  ���� *AreaMembers+   $ 50 $ Id�� �� *
PersonId+  $ Picture��$
 auto  �� .R�A� $��60��$��60������ $# UniformToFill=� �� *	Picture+ 	    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $  ��$ 60  �� .R��� $ 
Horizontal=�.+���  ��  �� " N�$ FindAncestor=�$ DataContext����� *SetAsLeaderCommand+���� $$ dgAreaMembers��.��  $ LifeRing=�$ Set As Leader��$��10��$��10���� $��2��$��2��#��[ $��20q�   $ 2Q�$ 3Q�._�� 	 �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� #��[ #��[ $��0��$��Groups��$
 10q�   $ 2Q�$ 2Q�$	 270Q�  -   $��	GroupGrid��$��30q�$��5q�$��1�� .   .  $	��500������ *Groups+   $ Group�� �� *Name+  $
 Area�� �� *Area.AreaName+  $ 60  �� .R��� $ 
Horizontal=�.+��� $��5q�$��Group�� ��  �� " N�$ FindAncestor=�$ DataContext����� *DeleteAssociationCommand+.��  $ Trash=�$ Delete Group��$��10��$��10���� $��2��$��5q�.+��� $��	Add Group��$��5q�#��[ �� $ 
Horizontal=�.+��� $��GroupName :��$	��150��$ Right=��� $	��150��$��5q����� *NewGroupName+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� $��Area :��$ Right=�$	��150���� $	��150��$��5q�% �� *	GroupArea+���� *Areas+���� .R��� ���� *
AreaName+�� $	��100��$	��Add��$��5q�$��Group������ *AddAssociationCommand+�� $��1��$��1��$��2��.+��� $ 
Horizontal=�$��20 10 10 10q� �� *GroupLeader+.+��� $��0,0,10,0q�._�A� $��60��$��60������  �� *	Picture+ 	  �� .+���   . $��5q�#��[ ._��� 
�������$��12(�$
 	10,7,10,0q�$��Group Leader���� $ 
Horizontal=�.+��� $ Center=�$��3q����� *	FirstName+$! 	No Leader���� $ Center=�$��3q����� *
LastName+  -   $��dgGroupMembers�� .  $	��600��$��7��$��1��$��2��$��10q�$" *  .  ���� *GroupMembers+   $ 50 $ Id�� �� *
PersonId+  $ Picture��$
 auto  �� .R�A� $��60��$��60������ $# UniformToFill=� �� *	Picture+ 	    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $  ��$ 60  �� .R��� $ 
Horizontal=�.+���  ��  �� " N�$ FindAncestor=�$ DataContext����� *SetAsLeaderCommand+���� $$ dgGroupMembers��.��  $ LifeRing=�$ Set As Leader��$��10��$��10���� $��3��$��2��#��[ $��20q�   $ 2Q�$ 3Q�._�� 	 �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� #��[ #��[ $��0��$��Classes��$
 10q�   $ 2Q�$ 2Q�$	 270Q�  -   $��	ClassGrid��$��30q�$��5q�$��1�� .   .  $	��500������ *	Classes+   $ Class�� �� *Name+  $
 Area�� �� *Area.AreaName+  $ 60  �� .R��� $ 
Horizontal=�.+��� $��5q�$��Class�� ��  �� " N�$ FindAncestor=�$ DataContext����� *DeleteAssociationCommand+.��  $ Trash=�$ Delete Class��$��10��$��10���� $��2��$��5q�.+��� $��	Add Class��$��5q�#��[ �� $ 
Horizontal=�.+��� $��Class Name :��$	��150��$ Right=��� $	��150��$��5q����� *NewClassName+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� $��Area :��$ Right=�$	��150���� $	��150��$��5q�% �� *	ClassArea+���� *Areas+���� .R��� ���� *
AreaName+�� $	��100��$	��Add��$��5q�$��Class������ *AddAssociationCommand+�� $��1��$��1��$��2��.+��� $ 
Horizontal=�$��20 10 10 10q� �� *ClassLeader+.+��� $��0,0,10,0q�._�A� $��60��$��60������  �� *	Picture+ 	  �� .+���   . $��5q�#��[ ._��� 
�������$��12(�$
 	10,7,10,0q�$��Class Leader���� $ 
Horizontal=�.+��� $ Center=�$��3q����� *	FirstName+$! 	No Leader���� $ Center=�$��3q����� *
LastName+  -	   $��dgClassMembers�� .  $	��600��$��10��$��1��$��2��$��10q�$" *  .  ���� *ClassMembers+   $ 50 $ Id�� �� *
PersonId+  $ Picture��$
 auto  �� .R�A� $��60��$��60������ $# UniformToFill=� �� *	Picture+ 	    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $  ��$ 60  �� .R��� $ 
Horizontal=�.+���  ��  �� " N�$ FindAncestor=�$ DataContext����� *SetAsLeaderCommand+���� $$ dgClassMembers��.��  $ LifeRing=�$ Set As Leader��$��10��$��10���� $��4��$��2��#��[ $��20q�   $ 2Q�$ 3Q�._�� 	 �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� #��[ #��[ $��0��$��Ministry��$
 10q�   $ 2Q�$ 2Q�$	 270Q�  -
   $��MinistryGrid��$��30q�$��5q�$��1�� .  $	��500�� .  ���� *
Ministries+   $ Ministry�� �� *MinistryName+  $ 60  �� .R��� $ 
Horizontal=�.+��� $��5q�$��Ministry�� ��  �� " N�$ FindAncestor=�$ DataContext����� *DeleteAssociationCommand+.��  $ Trash=�$ Delete Ministry��$��10��$��10���� $��2��$��5q�.+��� $��Add Ministry��$��5q�#��[ �� $ 
Horizontal=�.+��� $��Ministry Name :��$	��150��$ Right=��� $	��150��$��5q����� *NewMinistryName+$ PropertyChanged=�$ TwoWay=��� $	��100��$	��Add��$��5q�$��Ministry������ *AddAssociationCommand+�� $��1��$��1��$��2��.+��� $ 
Horizontal=�$��20 10 10 10q� �� *MinistryLeader+.+��� $��0,0,10,0q�._�A� $��60��$��60������  �� *	Picture+ 	  �� .+���   . $��5q�#��[ ._��� 
�������$��12(�$
 	10,7,10,0q�$��Ministry Leader���� $ 
Horizontal=�.+��� $ Center=�$��3q����� *	FirstName+$! 	No Leader���� $ Center=�$��3q����� *
LastName+  -   $��dgMinistryMembers�� .  $	��600��$��13��$��1��$��2��$��10q�$" *  .  ���� *MinistryMembers+   $ 50 $ Id�� �� *
PersonId+  $ Picture��$
 auto  �� .R�A� $��60��$��60������ $# UniformToFill=� �� *	Picture+ 	    $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  $  ��$ 60  �� .R��� $ 
Horizontal=�.+���  ��  �� " N�$ FindAncestor=�$ DataContext����� *SetAsLeaderCommand+���� $$ dgMinistryMembers��.��  $ LifeRing=�$ Set As Leader��$��10��$��10��