   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.PeoplePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  0cv'clr-namespace:ShortBody.ValueConverters  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    N� ShowsNavigationUI  .   � 	Resources ��%    .���  � RowDefinitions �� $
��Auto ��� $��* � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�@��� $	��All���� $
��Name���� $
��Area���� $��Ministry���� $��
FamilyName���� $��	BirthDate���� -   $��txtSearchBox��$	��150��$��10,0,5,0q�$y�	Collapsed=����� *SearchString+$ PropertyChanged=�$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchPersonCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Persons��$��1��$��3��	   CanClose	 .  
   Content
 �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q� � ToolTip$ Add New Person��  b_Button#��[ .��
Add Person�� 
�������$��1��$��5,5,5,5q��� $��5,5,5,5q�#��[ ���� *DeletePersonCommand+.��Delete Person�� -   $��5,5,5,5q�#��[ ���� *EditClickCommand+.��Edit Person&   System.Windows.Controls.DataGrid  -   
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1��   CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(�   AutoGenerateColumns .  ���� *	AllPeople+$ PropertyChanged=�$ TwoWay=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width$ 50    Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
PersonId+  $ 	FirstName�� �� *	FirstName+  $ LastName�� �� *
LastName+  -     Name$ AddPersonWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddPersonWindow_Loaded��$��1��$��1��$ 
Add Person��$	��600��.
 �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $ Clear Boxes������ *
ClearBoxes+.��"  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�$��20��$��3,0,0,0q��� $��1��$
��Auto=�.��� $	��Top=�#���    � DataContext �� *	NewPerson+ �� $
��auto ��� $
��auto ��� $	��87* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��1��$��2��.+��� $��1��$	��100��$	��100������ *	Picture+$ PropertyChanged=�$ TwoWay=�  �� 	Converter  4	   .ShortBody.ValueConverters.ByteToImageConverter	  �� $��Choose Picture��$��30��$��10q�$	��150�� ��  �� " N�$ FindAncestor=�$ DataContext����� *BrowsePicCommand+�� $��5q�$��2��.+��� #��[ $��Ghana Card Id :��$ Right=�$��10q�$��Center=��� #��[ $��*FirstName :��$ Right=�$��10q�$��Center=��� #��[ $��*LastName :��$ Right=�$��10q�$��Center=��� #��[ $��OtherNames :��$ Right=�$��10q�$��Center=��� #��[ $��*Date Of Birth :��$ Right=�$��10q�$��Center=��� #��[ $��*Phone :��$ Right=�$��10q�$��Center=��� #��[ $��	*Gender :��$ Right=�$��10q�$��Center=��� #��[ $��Marital Status :��$ Right=�$��10q�$��Center=��� #��[ $��	Service :��$ Right=�$��10q�$��Center=��� #��[ $��ResidentialArea :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��2��.+��� $��5,0,5,10q����� *GhanaCardId+�� $��	5,10,5,10q����� *	FirstName+�� $��	5,10,5,10q����� *
LastName+�� $��	5,10,5,10q����� *
OtherNames+(
  "System.Windows.Controls.DatePicker
  ! 
  DisplayDate$! 1/1/2018��$��33��$��	5,10,5,10q�" 
  SelectedDate" �� *DateOfBirth+$ PropertyChanged=�$ TwoWay=��� $��	5,10,5,10q����� *Phone+�� $��	5,10,5,10q� �� *Gender+$ PropertyChanged=�$ TwoWay=�@��� .��Male�� .��Female�� $��	5,10,5,10q� �� *MaritalStatus+$ PropertyChanged=�$ TwoWay=�@��� .��	Married�� .��Single�� .��
Divorced�� .��	Widowed�� -   $��	5,10,5,10q� �� *	Service+$ PropertyChanged=�$ TwoWay=�@��� .��
Children�� .��Adults�� $��	5,10,5,10q����� *ResidentialArea+�� $��2��$��5q�$��2��.+��� #��[ $��Email Adress :��$ Right=�$��10q�$��Center=��� #��[ $��Home Address (Gps) :��$ Right=�$��10q�$��Center=��� #��[ $��HomeTown Address (Gps) :��$ Right=�$��10q�$��Center=��� #��[ $��Baptism Date :��$ Right=�$��10q�$��Center=��� #��[ $��Place Of Baptism :��$ Right=�$��10q�$��Center=��� #��[ $��Family :��$ Right=�$��10q�$��Center=��� -   #��[ $��Group��$ Right=�$��10q�$��Center=��� #��[ $��Blood Group :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��2��.+��� $��5,0,5,10q����� *Email+�� $��	5,10,5,10q����� *HomeAddressGps+�� $��	5,10,5,10q����� *HomeTownAddressGps+
  $��33��$��	5,10,5,10q�" �� *BaptismDate+$ PropertyChanged=�$ TwoWay=��� $��	5,10,5,10q����� *PlaceOfBaptism+�� -	   $��	5,10,5,10q�# �� SelectedItem# �� *Family+$ PropertyChanged=�$ TwoWay=����� .R��� ���� *
FamilyName+�� -
   $��	5,10,5,10q� ��  �� $ FindAncestor=�$
 PageL�$ DataContext�# �� *Association+$ PropertyChanged=�$ TwoWay=����� .R��� ���� *Name+�� $��	5,10,5,10q� �� *
BloodGroup+$ PropertyChanged=�$ TwoWay=�.@��� .��A+�� .��A-�� .��B+�� .��B-�� .��AB+�� .��AB-�� .��O+�� .��O-�� -   $
��Save��$��10q�$��70�� ��  �� " N�$ FindAncestor=�$ DataContext����� *SaveNewPersonCommand+�� -   $��Save Changes��$��10q�$��70��$y�	Collapsed=� ��  �� " N�$ FindAncestor=�$ DataContext����� *EditPersonCommand+  -   $ PersonWindow��$ PersonWindow_Loaded��$��1��$��1��$	��600��$y�	Collapsed=�.
 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� -   $��5q�$ View Person's Details��#��[ .��	Details�� -   $��5q�$ View Person's Family��#��[ .��Family�� -   $��5q�$ View Person's Services��#��[ .��
Services�� $��1��$��2��$
��Auto=�.�� � -   