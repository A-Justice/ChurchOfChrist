   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.ChurchPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  9an0clr-namespace:ShortBody.Resources.Helper_Methods  0cv'clr-namespace:ShortBody.ValueConverters  .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $
��Name���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchChurchCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Churches��$��1��$��2��   CanClose .     Content �   �� $
��auto ��� $
��241* ��� $��10 �.+�]�   myDirtyWhite#��[ .+��� -   $��5q�	 � ToolTip$	 Add New Church��  b_Button#��[ $��
Add Church���� 
�������$��1��$��5,5,1,5q��� $��1,5,5,5q�#��[ ���� *DeleteChurchCommand+.���� $ 
Horizontal=�$	 Delete Church��.+�"  FontAwesome.WPF.ImageAwesome  
   Icon$
 Trash=�$��20���� 
�������$��1��$��5,5,1,5q��� -   $��5q�$	 Add New Account Detail��#��[ $��Add Account Detail������ *GeneralCommand+�� -   $��5q�$	 View Account Details��#��[ $��View Account Detail������ *GeneralCommand+�� -   $��5q�$#	 Change Selected Church's Logo��#��[ $��Right=����� *GeneralCommand+.��  $
 Image=�$��20��&   System.Windows.Controls.DataGrid  -   ��.  
���   �$��2��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1��:   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns .    CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(����� *AllChurches+$ PropertyChanged=�$ TwoWay=�  -     Name$ AddChurchWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ churchWindow_Loaded��$��1��$��1��$ 
Add Church��$	��600��. �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.��  $
 
PaintBrush=�$��20��$��3,0,0,0q�� $��1��#���    � DataContext �� *	NewChurch+  �� $
��auto ��� $	��87* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+��� $	��100��$��1��$��10q����� *Logo+$ PropertyChanged=�$ TwoWay=� ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��Center=� ��  �� " >�$ FindAncestor=�$ DataContext�.+���   tb#��[ $��Logo :��$��Right=��� $��Browse��#��[ $��10q�$��60��$��Right=����� *BrowseCommand+�� #��[ $��5q�$��2��$��Center=� �� TextAlignment$ Center=����#CA5100$��2������ *Error+$ PropertyChanged=� ��  �� " >�$ FindAncestor=�$ DataContext��� $��5q�$��1��.+��� #��[ $��Name :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��	Address :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��Slogan :��$ Right=�$��10q�$��Center=�$��30���� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *Name+�� $��	5,10,5,10q����� *	Address+�� $��	5,10,5,10q����� *Slogan+�� $��2��$��5q�$��1��.+��� #��[ $��Phone :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��Email Adress :��$ Right=�$��10q�$��Center=�$��30���� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *Phone+�� $��	5,10,5,10q����� *Email+�� $
��Save��$��50��$��20q� ��  �� " >�$ FindAncestor=�$ DataContext����� *SaveChurchCommand+� $��1��$��1��.+�  -	   $ AddAccDetailWindow��$ churchWindow_Loaded��$ Add Account Detail��. �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.��  $
 
PaintBrush=�$��20��$��3,0,0,0q�� $��2��$��1��#���    �� *NewChurchAccount+  �� $
��auto ��� $	��87* � �� $��* ��� $��* �.+��� #��[ $��5q�$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� " >�$ FindAncestor=�$ DataContext��� $��0��$��5q�$��1��.+��� #��[ $��Account Name :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��Account Number :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��Bank Name :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��Bank Branch :��$ Right=�$��10q�$��Center=�$��30���� $��3��$��5q�$��1��$	��100��.+��� $��	5,10,5,10q����� *AccountName+�� $��	5,10,5,10q����� *AccountNumber+�� $��	5,10,5,10q����� *
BankName+�� $��	5,10,5,10q����� *
BankBranch+�� $
��Save��$��50�� ��  �� " >�$ FindAncestor=�$ DataContext����� *SaveAccountCommand+  -
   $ ViewAccWindow��$��3��$	��350��$��2��$ Account Details�� � #���     �� $
��Auto ��� $��* �.+��� $ 
Horizontal=�#��[ .+��� $��10,5,5,5q�#��[ $	 Delete Account Detail������ *DeleteAccDetailCommand+.��  $
 Trash=�$��20��  -   $��1��$ *  . $��30q�   AutoGenerateColumns .  .  ���� *FocusedChurch.AccountDetails+$ PropertyChanged=�$ TwoWay=�