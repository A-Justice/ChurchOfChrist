   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ShortBody.MiniPagesShortBody.MiniPages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  %    ShortBody.MiniPages.DetailsMini   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:ShortBody.MiniPages     >ctr.clr-namespace:ShortBody.Resources.UserControls     6cv'clr-namespace:ShortBody.ValueConverters     W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    � 	Resources     	tbOutline �� 
TargetType  tb �� BasedOn �� Property �� Value��%�   &	        7  &	 @     7  �� " ��8   .���  � ��$
 Bold"���  � ��$ 14(��� " ��8   .���  � ��$ 14(�.���� $
��auto=�.��� $	��850��  MaterialDesignPaper#���   � DataContext �� *SelectedPerson+ � RowDefinitions �� $
��auto ��� $
��auto ��� $	��87* � � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+��� $��1��$��1��$��2��.+��� $	��100��$	��100��$��10q����� *	Picture+ �� 	Converter 4   .ShortBody.ValueConverters.ByteToImageConverter  �� $��5q�$��2��.+��� #��[  $��Ghana Card Id :��	 �� TextAlignment$	 Right=�$��10q�$��Center=��� #��[  $��FirstName :��$	 Right=�$��10q�$��Center=��� $��10q�#��[  $��Center=�$	 Right=�$��
LastName :���� $��10q�#��[  $��Center=�$	 Right=�$��OtherNames :���� #��[  $��Date Of Birth :��$	 Right=�$��10q�$��Center=��� #��[  $��Phone :��$	 Right=�$��10q�$��Center=��� #��[  $��Gender :��$	 Right=�$��10q�$��Center=��� #��[  $��Marital Status :��$	 Right=�$��10q�$��Center=��� #��[  $��Membership Date :��$	 Right=�$��10q�$��Center=��� #��[  $��	Service :��$	 Right=�$��10q�$��Center=��� #��[  $��Residential Area :��$	 Right=�$��10q�$��Center=��� #��[  $��BloodGroup :��$	 Right=�$��10q�$��Center=��� #��[  $��Home Address (Gps) :��$	 Right=�$��10q�$��Center=��� $��1��$��5q�$��2��.+��� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *GhanaCardId+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *	FirstName+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *
LastName+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *
OtherNames+�� #��[ $��	5,10,5,10q����� *DateOfBirth+ 1   +ShortBody.ValueConverters.LongDateFormatter  �� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Phone+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Gender+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *MaritalStatus+�� #��[ $
	 Left=�$��	5,10,5,10q����� *MembershipDate+   �� #��[ $
	 Left=�$��	5,10,5,10q����� *	Service+�� #��[ $
	 Left=�$��	5,10,5,10q����� *ResidentialArea+�� #��[ $
	 Left=�$��	5,10,5,10q����� *
BloodGroup+�� #��[ $
	 Left=�$��	5,10,5,10q����� *HomeAddressGps+�� $��2��$��5q�$��2��.+��� #��[  $��HomeTown Address (Gps) :��$	 Right=�$��
10,10,0,10q�$��Center=�$
��Left=�$	��160���� #��[  $��Email Adress :��$	 Right=�$��10q�$��Center=��� #��[  $��Baptism Date :��$	 Right=�$��10q�$��Center=��� #��[  $��Place Of Baptism :��$	 Right=�$��10q�$��Center=��� #��[  $��Family :��$	 Right=�$��10q�$��Center=��� #��[  $��Zone :��$	 Right=�$��10q�$��Center=��� $��55��#��[  $��Area :��$	 Right=�$��10q�$��Center=��� #��[  $��Group :��$��55��$	 Right=�$��10q�$��Center=�y��� *Group+ <   6ShortBody.ValueConverters.ContentToVisibilityConverter  �� #��[  $��Class :��$	 Right=�$��10q�$��Center=�y��� *Class+   �� #��[  $��Membership Type :��$	 Right=�$��10q�$��Center=��� #��[  $��Status :��$	 Right=�$��10q�$��Center=��� $��3��$��5q�$��2��.+��� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *HomeTownAddressGps+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Email+�� #��[ $��	5,10,5,10q����� *BaptismDate+   �� #��[ $��	5,10,5,10q����� *PlaceOfBaptism+   �� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Family.FamilyName+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Group.Area.Zone.ZoneName+�� $��Center=�$��55��$
	 Left=�#��[ $��	5,10,5,10q����� *Group.Area.AreaName+�� $��Center=�$��55��$
	 Left=�#��[ $��	5,10,5,10q����� *
Group.Name+y��� *Group+   �� #��[ $��Center=�$
	 Left=�$
��Wrap=�$��	5,10,5,10q����� *
Class.Name+y��� *Class+   �� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *MembershipType+�� #��[ $��Center=�$
	 Left=�$��	5,10,5,10q����� *Status+