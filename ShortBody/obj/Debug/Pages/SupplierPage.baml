   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5      W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5
      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5      "    ShortBody.Pages.SupplierPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   9an0clr-namespace:ShortBody.Resources.Helper_Methods  5      8ctr.clr-namespace:ShortBody.Resources.UserControls  5
      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      0cv'clr-namespace:ShortBody.ValueConverters  5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5       .+�5"      �� $��
SearchBy :��6   $��Center=�6.   $��17(�5#      �� 5$      -   5        $��cboSearchBox��5$      $��80��6`   $��Center=�6k   $��5,0,5,0q�5%   5    �� Text 6   �� *
SearchBy+@�5&      �� 5'      $	��All��6'   �� 5(      $
��Name��6'   �� 5)      $��Email��6'   5+      �� 5-      -   5        $��txtSearchBox��5-      $	��150��6.   $��10,0,5,0q�6:   ��6L   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5/        BoderlessButton#��[ 6   $��17(�50      $��5,0,5,0q�6(   ��51      �� *SearchSupplierCommand+.��6D   Search53      54      55      1   +ShortBody.Resources.UserControls.miniWindow  58   
   
������    
HeaderText$ All Suppliers��63   $��1��59      $��3��6&      CanClose .     Content 5;      � 5<        5=      �� 5>      $
��auto �6(   �� 5?      $
��241* �6(   �� 5@      $��10 �6(   .+�5B      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5C      .+�5D      �� -   5        $��5q�5D   "   	 � ToolTip$	 Add New Supplier��6-     b_Button#��[ 5E      .��5F      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�6.   $��20��6>   5G      �� 5H      
�������$��1��61   $��5,5,5,5q�6;   �� 5J      $��5,5,5,5q�6"   #��[ 63   ��6U   �� *DeleteSupplierCommand+.��5K      �� $ 
Horizontal=�6)   $	 Delete Supplier��6B   .+�5L   "     $
 Trash=�62   $��20��6?   5N      5O      5R      &   System.Windows.Controls.DataGrid  5T      -   5        :   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns . 
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5U      $��2��6.      CanUserAddRows .  $��1��6W      CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(�5W   ?   ��5T   P   �� *AllSuppliers+$ PropertyChanged=�$ OneWay=�5Y      5Z      5\        5^   
   -   5          Name$ AddSupplierWindow��5_      1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddSupplierWindow_Loaded��5`      $��1��5^      $��1��6&   $ Add Supplier��66   $	��600��5_   4   . 5a      �   5b      �� 5c      $
��auto �6$   �� 5d      $
��241* �6$   �� 5e      $��10 �6$   .+�5g      �� $ 
Horizontal=�6   #��[ 5h      .+�5j      �� $��10,5,5,5q�6   #��[ 60   $	 Clear Boxes��5k      ��64   �� *
ClearBoxes+.��5l        $
 
PaintBrush=�6*   $��20��6<   5n      �� 5p      
�������$��1��6-   $��5,5,1,5q�67   5s      � 5u      $��1��6   $��2��6$   #���   65    � DataContext 6h   �� *NewSupplier+  5v      �� 5w      $
��auto �6(   �� 5x      $��* �6(    5z      �� 5{      $
��Auto �6+   �� 5|      $��* �6+   �� 5}      $
��Auto �6+   �� 5~      $��* �6+   .+�5�      ��   tb#��[ 6    $��5q�6w    �� TextAlignment$ Center=�5�   $   ���#CA5100$��4��6P   ��5�   <   �� *Error+$ PropertyChanged=� 5�   $   ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� 5�      $��5q�6!   $��1��6,   .+�5�      �� #��[ 6$   $��Name :��6@   $ Right=�6N   $��10q�6d   $��Center=�5�   $   �� 5�      #��[ 6$   $��	Address :��6@   $ Right=�6Q   $��10q�6g   $��Center=�5�   $   5�      �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�69   ��6"   �� *Name+69   �� 5�      $��	5,10,5,10q�6<   ��6"   �� *	Address+6<   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��Phone :��6@   $ Right=�6O   $��10q�6e   $��Center=�5�   $   �� 5�      #��[ 6$   $��Email Adress :��6@   $ Right=�6V   $��10q�6l   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6:   ��6"   �� *Phone+6:   �� 5�      $��	5,10,5,10q�6:   ��6"   �� *Email+6:   �� 5�      $
��Save��6!   $��50��5�   L    5�   0   ��  �� " >�$ FindAncestor=�$ DataContext���5�   !   �� *SaveNewSupplierCommand+6L   5�      5�      5�      5�      5�      5�      